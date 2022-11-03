using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        /* Block Variables */
        private DateTime timestamp; // creation time

        private int index, // Block position in the sequence
            difficulty = 4; // zeros to preceed a hash value

        public String prevHash, // pointer to previous block
            hash, // The current blocks "identity"
            merkleRoot,  // The merkle root of all transactions in the block
            minerAddress; // Public key of the miner (wallet)

        public List<Transaction> transactionList; // List of transactions in this block
        
        // Proof-of-work
        public long nonce; // number used only once for PoW and mining
        public long nonce0 = 0;
        public long nonce1 = 1;
        public String hash0 = "";
        public String hash1 = "";
        public bool thread0 = false;
        public bool thread1 = false;


        public double reward; 

        /* Genesis block constructor */
        public Block()
        {
            timestamp = DateTime.Now;
            index = 0;
            transactionList = new List<Transaction>();
            

            hash = Mine();

        }

        /* New Block constructor */
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            timestamp = DateTime.Now;

            index = lastBlock.index + 1;
            prevHash = lastBlock.hash;

            this.minerAddress = minerAddress; // wallet to be credited the reward for the mining
            reward = 2.0; // fixed reward for mining
            transactions.Add(createRewardTransaction(transactions)); // create and append reward transaction
            transactionList = new List<Transaction>(transactions); 

            merkleRoot = MerkleRoot(transactionList); // calculate the merkle root of the block transactions
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // start stopwatch
            if (BlockchainApp.threadingison == true) // if user selected multithreading
            {
                hash = MultiThreadMine(); 
            }
            else
            {
                hash = Mine();
            }
            stopwatch.Stop(); // stop stopwatch
            Console.WriteLine("Time taken to create Block:  "+stopwatch.ElapsedMilliseconds);
        }

        /* Hashes the entire Block object */
        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();

        
            String input = timestamp.ToString() + index + prevHash + nonce + merkleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            
            return hash;
        }
        public String CreateHash(long nonce)
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();

            String input = timestamp.ToString() + index + prevHash + nonce + merkleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            /* Reformat to a string */
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);

            return hash;
        }

        // create a Hash which satisfies the diff level required for PoW
        public String Mine()
        {
            nonce = 0; // initalise the nonce
            String hash = CreateHash(); // create block hash

            String re = new string('0', difficulty); // string to analyse PoW requirement

            while (!hash.StartsWith(re)) 
            {
                nonce++; // Increment the nonce should the diff level not be satisfied
                hash = CreateHash(); // Rehash with the new nonce as to generate a different hash
            }



            return hash; // Return the hash meeting the diff requirement
        }

        public String MultiThreadMine()
        {
            String difficulty_Diff = new string('0', difficulty); // string to analyse PoW requirement
            // create the threads
            Thread thread1 = new Thread(Mine0); 
            Thread thread2 = new Thread(Mine1);

            thread1.Start(); // starting thread
            thread2.Start(); // starting thread

            while (thread1.IsAlive == true || thread2.IsAlive == true)
            {
                Thread.Sleep(1);
            }

            if (hash0.StartsWith(difficulty_Diff) == true){ // compare whether hash1 matches diff string then return hash1 as main hash

                nonce = nonce0;
                return hash0;
            }
            else // return hash2 as the main
            {
                nonce = nonce1;
                return hash1;
            }

        }

        public void Mine0()
        {
            
            thread0 = false;
            Boolean check = false;
            String Hash;
            string difficultyDiff = new string('0', this.difficulty); // string to analyse PoW requirement

            while (check == false) // loop until condition is met
            {
                Hash = CreateHash(nonce0); // create temporary hash
                if (Hash.StartsWith(difficultyDiff) == true)
                {
                    check = true;
                    hash0 = Hash;
                    thread0 = true;
                    return;
                }
                else if (thread0 == true) //if this thread is finished, put the other thread to sleep
                {
                    Thread.Sleep(1);
                    return;
                }
                else
                {
                    check = false;
                    nonce0 += 2; // return nonce with increment
                }
            }
            return;
        }
        public void Mine1()
        {
            thread1 = false;
            Boolean check = false;
            String Hash;
            string difficultyDiff = new string('0', this.difficulty);

            while (check == false)
            {
                Hash = CreateHash(nonce1);
                if (Hash.StartsWith(difficultyDiff) == true)
                {
                    check = true;
                    hash1 = Hash;                    
                    thread0 = true;


                    return;
                }
                else if (thread1 == true)
                {
                    Thread.Sleep(1);
                    return;
                }
                else
                {
                    check = false;
                    nonce1 += 2;
                }
            }
            return;
        }



        // Merkle Root Algorithm - Encodes transactions within a block into a single hash
        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList(); // Get a list of transaction hashes for "combining"
            
            // Handle Blocks with...
            if (hashes.Count == 0) // No transactions
            {
                return String.Empty;
            }
            if (hashes.Count == 1) // One transaction - hash with "self"
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            }
            while (hashes.Count != 1) // Multiple transactions - Repeat until tree has been traversed
            {
                List<String> merkleLeaves = new List<String>(); // Keep track of current "level" of the tree

                for (int i=0; i<hashes.Count; i+=2) // Step over neighbouring pair combining each
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i])); // Handle an odd number of leaves
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1])); // Hash neighbours leaves
                    }
                }
                hashes = merkleLeaves; // Update the working "layer"
            }
            return hashes[0]; // Return the root node
        }

        // Create reward for incentivising the mining of block
        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            double fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee); // Sum all transaction fees
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, ""); // Issue reward as a transaction in the new block
        }

        /* Concatenate all properties to output to the UI */
        public override string ToString()
        {
            return "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timestamp
                + "\nPrevious Hash: " + prevHash
                + "\n-- PoW --"
                + "\nDifficulty Level: " + difficulty
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiners Address: " + minerAddress
                + "\n-- " + transactionList.Count + " Transactions --"
                +"\nMerkle Root: " + merkleRoot
                + "\n" + String.Join("\n", transactionList)
                + "\n[BLOCK END]";
        }
    }
}
