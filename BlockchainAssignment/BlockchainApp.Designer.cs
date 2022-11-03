namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockNo = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.reciever = new System.Windows.Forms.TextBox();
            this.recieverKeyLabel = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.printBlockchain = new System.Windows.Forms.Button();
            this.readPendingTransactions = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.blocksLabel = new System.Windows.Forms.Label();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.threading_box = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Greedy = new System.Windows.Forms.RadioButton();
            this.Random = new System.Windows.Forms.RadioButton();
            this.Altrustic = new System.Windows.Forms.RadioButton();
            this.Adress = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(16, 15);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(812, 508);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(16, 529);
            this.printBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(88, 31);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Print Block";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.PrintBlock_Click);
            // 
            // blockNo
            // 
            this.blockNo.Location = new System.Drawing.Point(112, 533);
            this.blockNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockNo.Name = "blockNo";
            this.blockNo.Size = new System.Drawing.Size(61, 22);
            this.blockNo.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(676, 704);
            this.generateWallet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(104, 73);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate New Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.GenerateWallet_Click);
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(368, 533);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(74, 17);
            this.publicKeyLabel.TabIndex = 4;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(362, 561);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(80, 17);
            this.privateKeyLabel.TabIndex = 5;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(448, 533);
            this.publicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(251, 22);
            this.publicKey.TabIndex = 6;
            this.publicKey.TextChanged += new System.EventHandler(this.publicKey_TextChanged);
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(448, 561);
            this.privateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(251, 22);
            this.privateKey.TabIndex = 7;
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(705, 533);
            this.validateKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(116, 27);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(223, 663);
            this.createTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(260, 32);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(371, 704);
            this.fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(47, 22);
            this.fee.TabIndex = 13;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(282, 704);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(47, 22);
            this.amount.TabIndex = 12;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(335, 704);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(32, 17);
            this.feeLabel.TabIndex = 11;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(220, 704);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount";
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(207, 735);
            this.reciever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(297, 22);
            this.reciever.TabIndex = 15;
            // 
            // recieverKeyLabel
            // 
            this.recieverKeyLabel.AutoSize = true;
            this.recieverKeyLabel.Location = new System.Drawing.Point(109, 735);
            this.recieverKeyLabel.Name = "recieverKeyLabel";
            this.recieverKeyLabel.Size = new System.Drawing.Size(92, 17);
            this.recieverKeyLabel.TabIndex = 14;
            this.recieverKeyLabel.Text = "Reciever Key";
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(540, 704);
            this.newBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(93, 73);
            this.newBlock.TabIndex = 16;
            this.newBlock.Text = "Generate New Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.NewBlock_Click);
            // 
            // printBlockchain
            // 
            this.printBlockchain.Location = new System.Drawing.Point(179, 529);
            this.printBlockchain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlockchain.Name = "printBlockchain";
            this.printBlockchain.Size = new System.Drawing.Size(132, 31);
            this.printBlockchain.TabIndex = 17;
            this.printBlockchain.Text = "Print Entire Chain";
            this.printBlockchain.UseVisualStyleBackColor = true;
            this.printBlockchain.Click += new System.EventHandler(this.ReadAll_Click);
            // 
            // readPendingTransactions
            // 
            this.readPendingTransactions.Location = new System.Drawing.Point(12, 774);
            this.readPendingTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readPendingTransactions.Name = "readPendingTransactions";
            this.readPendingTransactions.Size = new System.Drawing.Size(204, 31);
            this.readPendingTransactions.TabIndex = 18;
            this.readPendingTransactions.Text = "Read Pending Transactions";
            this.readPendingTransactions.UseVisualStyleBackColor = true;
            this.readPendingTransactions.Click += new System.EventHandler(this.PrintPendingTransactions_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(12, 674);
            this.validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(187, 39);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(714, 579);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(107, 57);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // blocksLabel
            // 
            this.blocksLabel.AutoSize = true;
            this.blocksLabel.Location = new System.Drawing.Point(841, 15);
            this.blocksLabel.Name = "blocksLabel";
            this.blocksLabel.Size = new System.Drawing.Size(49, 17);
            this.blocksLabel.TabIndex = 24;
            this.blocksLabel.Text = "Blocks";
            this.blocksLabel.Click += new System.EventHandler(this.blocksLabel_Click);
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(91, 625);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(531, 22);
            this.addresstextbox.TabIndex = 30;
            // 
            // threading_box
            // 
            this.threading_box.AutoSize = true;
            this.threading_box.Location = new System.Drawing.Point(692, 642);
            this.threading_box.Margin = new System.Windows.Forms.Padding(4);
            this.threading_box.Name = "threading_box";
            this.threading_box.Size = new System.Drawing.Size(129, 21);
            this.threading_box.TabIndex = 31;
            this.threading_box.Text = "Multi-Threading";
            this.threading_box.UseVisualStyleBackColor = true;
            this.threading_box.CheckedChanged += new System.EventHandler(this.threading_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(692, 670);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Adjust Difficulty";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Greedy
            // 
            this.Greedy.AutoSize = true;
            this.Greedy.Location = new System.Drawing.Point(13, 597);
            this.Greedy.Margin = new System.Windows.Forms.Padding(4);
            this.Greedy.Name = "Greedy";
            this.Greedy.Size = new System.Drawing.Size(76, 21);
            this.Greedy.TabIndex = 26;
            this.Greedy.TabStop = true;
            this.Greedy.Text = "Greedy";
            this.Greedy.UseVisualStyleBackColor = true;
            this.Greedy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(91, 597);
            this.Random.Margin = new System.Windows.Forms.Padding(4);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(82, 21);
            this.Random.TabIndex = 27;
            this.Random.TabStop = true;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.Random_CheckedChanged_1);
            // 
            // Altrustic
            // 
            this.Altrustic.AutoSize = true;
            this.Altrustic.Location = new System.Drawing.Point(181, 597);
            this.Altrustic.Margin = new System.Windows.Forms.Padding(4);
            this.Altrustic.Name = "Altrustic";
            this.Altrustic.Size = new System.Drawing.Size(79, 21);
            this.Altrustic.TabIndex = 28;
            this.Altrustic.TabStop = true;
            this.Altrustic.Text = "Altrustic";
            this.Altrustic.UseVisualStyleBackColor = true;
            this.Altrustic.CheckedChanged += new System.EventHandler(this.Altrustic_CheckedChanged_1);
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(12, 625);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(81, 21);
            this.Adress.TabIndex = 33;
            this.Adress.TabStop = true;
            this.Adress.Text = "Address";
            this.Adress.UseVisualStyleBackColor = true;
            this.Adress.CheckedChanged += new System.EventHandler(this.Adress_CheckedChanged);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 864);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.threading_box);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.Altrustic);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Greedy);
            this.Controls.Add(this.blocksLabel);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPendingTransactions);
            this.Controls.Add(this.printBlockchain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.recieverKeyLabel);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.blockNo);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.output);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.BlockchainApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockNo;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label recieverKeyLabel;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button printBlockchain;
        private System.Windows.Forms.Button readPendingTransactions;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Label blocksLabel;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.CheckBox threading_box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton Greedy;
        private System.Windows.Forms.RadioButton Random;
        private System.Windows.Forms.RadioButton Altrustic;
        private System.Windows.Forms.RadioButton Adress;
    }
}

