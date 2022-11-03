using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace BlockchainAssignment
{
    
    public partial class BlockchainApp : Form
    {
        // Global blockchain object
        private Blockchain blockchain;
        private int type;
        public static bool threadingison;
        public static bool difficulty_check;
        public static long firstTime;
        public static double timeAverage;
        public static int diff = 4;
        List<Transaction> address = new List<Transaction>();
        public static double sum;
        // Default App Constructor
        public BlockchainApp()
        {
            // Initialise UI Components
            InitializeComponent();
            // Create a new blockchain 
            blockchain = new Blockchain();
            // Update UI with an initalisation message
            UpdateText("New blockchain initialised!");
        }

        /* PRINTING */
        // Helper method to update the UI with a provided message
        private void UpdateText(String text)
        {
            output.Text = text;
        }

        // Print entire blockchain to UI
        private void ReadAll_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());
        }

        // Print Block N (based on user input)
        private void PrintBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockNo.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("Invalid Block No.");
        }

        // Print pending transactions from the transaction pool to the UI
        private void PrintPendingTransactions_Click(object sender, EventArgs e)
        {
            blockchain.transactionPool.Sort((j, i) => i.timestamp.CompareTo(j.timestamp));
            int k = blockchain.transactionPool.Count;
            Random random = new Random();
            if(Greedy.Checked == true) // if greedy is checked
            {
                type = 1;
            }
            if(Random.Checked == true) //if random is checked
            {
                type = 2;
            }
            if(Altrustic.Checked == true) // if altruistic is checked
            {
                type = 3;
            }
            if(Adress.Checked == true) // if address is checked
            {
                type = 4;
            }

            if(type == 1) // greedy
            {
                blockchain.transactionPool.Sort((i, j) => i.fee.CompareTo(j.fee)); // sort the transactions based on the highest fee
                blockchain.transactionPool.Reverse(); // reverse the order
       

            }
            else if(type == 2) // Random
            {
                while (k > 1)
                {
                    k--;
                    int j = random.Next(k + 1); // generate a random number
                    Transaction value = blockchain.transactionPool[j]; // pick the transaction with the random index
                    blockchain.transactionPool[j] = blockchain.transactionPool[k];
                    blockchain.transactionPool[k] = value;

                }

            }
            else if (type == 3) // Altruistic
            {
                blockchain.transactionPool.Sort((i, j) => i.timestamp.CompareTo(j.timestamp)); // sort transaction pool based on the time of creation
                UpdateText(String.Join("\n", blockchain.transactionPool));
            }
            else if (type == 4) // address based
            {
                address.Clear();
                foreach (Transaction transaction in blockchain.transactionPool)
                {
                    String findaddress = addresstextbox.Text; // get the specified address

                    if (findaddress.Equals(transaction.senderAddress)) // if it matches to a sender address
                    {
                        address.Add(transaction);

                    }
                }
                UpdateText(String.Join("\n",address));
            }
            if(type <4)
            {
                UpdateText(String.Join("\n", blockchain.transactionPool));
            }
            
        }

        /* WALLETS */
        // Generate a new Wallet and fill the public and private key fields of the UI
        private void GenerateWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privKey);

            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;
        }

        // Validate the keys loaded in the UI by comparing their mathematical relationship
        private void ValidateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
                UpdateText("Keys are valid");
            else
                UpdateText("Keys are invalid");
        }

        // Check the balance of current user
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.GetBalance(publicKey.Text).ToString() + " Assignment Coin");
        }


        /* TRANSACTION MANAGEMENT */
        // Create a new pending transaction and add it to the transaction pool
        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            /* TODO: Validate transaction */
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        /* BLOCK MANAGEMENT */
        // Conduct Proof-of-work in order to mine transactions from the pool and submit a new block to the Blockchain
        private void NewBlock_Click(object sender, EventArgs e)
        {
            sum = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Retrieve pending transactions to be added to the newly generated Block
            List<Transaction> transactions = blockchain.GetPendingTransactions();
            if (difficulty_check == true)
            {
                if (Blockchain.blocktime.Count > 3)
                {
                    firstTime = Blockchain.blocktime[0]; // time needed to create the block
                    foreach (long x in Blockchain.blocktime)
                    {

                        sum += x;
                    }
                    timeAverage = sum / 4; // the avarage of the last four created blocks
                    Console.WriteLine("First Block took " + firstTime + "  milliseconds to be created");
                    Console.WriteLine("Average time taken to create block in current diff:  " + timeAverage + " milliseconds");
                    Console.WriteLine(" ");
                    Blockchain.blocktime.Clear();

                    if (firstTime > timeAverage*1.20) // if time to create the block is more than the average time to create the last blocks
                    {
                        diff = diff - 1;// decrease diff

                        if (diff <= 2) // make sure diff is never less than 2
                        {
                            diff = 2;
                        }
                    }
                    if (firstTime < timeAverage*0.80) // if time to create the block is less than the average time to create the last blocks
                    {
                        diff = diff + 1; // increase the diff
                    }
                    Console.WriteLine("Difficulty adjusted to " + diff);


                }
                // Create and append the new block - requires a reference to the previous block, a set of transactions and the miners public address (For the reward to be issued)
                Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
                blockchain.blocks.Add(newBlock);

                stopwatch.Stop();

                UpdateText(blockchain.ToString());
            }

            if (difficulty_check == false)
            {
                // Create and append the new block - requires a reference to the previous block, a set of transactions and the miners public address (For the reward to be issued)
                Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
                blockchain.blocks.Add(newBlock);

                stopwatch.Stop();

                UpdateText(blockchain.ToString());


            }

        }
        /* BLOCKCHAIN VALIDATION */
        // Validate the integrity of the state of the Blockchain
        private void Validate_Click(object sender, EventArgs e)
        {
            // CASE: Genesis Block - Check only hash as no transactions are currently present
            if(blockchain.blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.blocks[0])) // Recompute Hash to check validity
                    UpdateText("Blockchain is invalid");
                else
                    UpdateText("Blockchain is valid");
                return;
            }

            for (int i=1; i<blockchain.blocks.Count-1; i++)
            {
                if(
                    blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash || // Check hash "chain"
                    !Blockchain.ValidateHash(blockchain.blocks[i]) ||  // Check each blocks hash
                    !Blockchain.ValidateMerkleRoot(blockchain.blocks[i]) // Check transaction integrity using Merkle Root
                )
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }

        private void currentWalletLabel_Click(object sender, EventArgs e)
        {

        }

        private void publicKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void validationLabel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void blocksLabel_Click(object sender, EventArgs e)
        {

        }

        private void BlockchainApp_Load(object sender, EventArgs e)
        {

        }

        private void threading_CheckedChanged(object sender, EventArgs e)
        {
            if (threading_box.Checked)
            {
                threadingison = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                difficulty_check = true;
            }
        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void Altrustic_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Random_CheckedChanged_1(object sender, EventArgs e)
        {
        
        }

        private void Adress_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}