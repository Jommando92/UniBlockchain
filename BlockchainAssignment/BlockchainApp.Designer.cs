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
            this.mainTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBotton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.genWallet = new System.Windows.Forms.Button();
            this.publicBox = new System.Windows.Forms.TextBox();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.publicKeyLab = new System.Windows.Forms.Label();
            this.privateKeyLab = new System.Windows.Forms.Label();
            this.validateKey = new System.Windows.Forms.Button();
            this.createTransation = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.keyReceiver = new System.Windows.Forms.TextBox();
            this.newKeylabel = new System.Windows.Forms.Label();
            this.GenNewBlock = new System.Windows.Forms.Button();
            this.pendingTransaction = new System.Windows.Forms.Button();
            this.ReadAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTextBox1
            // 
            this.mainTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.mainTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainTextBox1.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox1.Name = "mainTextBox1";
            this.mainTextBox1.Size = new System.Drawing.Size(913, 314);
            this.mainTextBox1.TabIndex = 0;
            this.mainTextBox1.Text = "";
            this.mainTextBox1.TextChanged += new System.EventHandler(this.mainTextBox1_TextChanged_1);
            // 
            // printBotton
            // 
            this.printBotton.Location = new System.Drawing.Point(13, 357);
            this.printBotton.Name = "printBotton";
            this.printBotton.Size = new System.Drawing.Size(75, 23);
            this.printBotton.TabIndex = 1;
            this.printBotton.Text = "PrintNow";
            this.printBotton.UseVisualStyleBackColor = true;
            this.printBotton.Click += new System.EventHandler(this.printBotton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(95, 357);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(163, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // genWallet
            // 
            this.genWallet.Location = new System.Drawing.Point(264, 357);
            this.genWallet.Name = "genWallet";
            this.genWallet.Size = new System.Drawing.Size(68, 47);
            this.genWallet.TabIndex = 3;
            this.genWallet.Text = "Generate Wallet";
            this.genWallet.UseVisualStyleBackColor = true;
            this.genWallet.Click += new System.EventHandler(this.genWallet_Click);
            // 
            // publicBox
            // 
            this.publicBox.Location = new System.Drawing.Point(338, 357);
            this.publicBox.Name = "publicBox";
            this.publicBox.Size = new System.Drawing.Size(488, 20);
            this.publicBox.TabIndex = 4;
            this.publicBox.TextChanged += new System.EventHandler(this.publicBox_TextChanged);
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(341, 384);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(488, 20);
            this.privateBox.TabIndex = 5;
            this.privateBox.TextChanged += new System.EventHandler(this.privateBox_TextChanged);
            // 
            // publicKeyLab
            // 
            this.publicKeyLab.AutoSize = true;
            this.publicKeyLab.Location = new System.Drawing.Point(832, 365);
            this.publicKeyLab.Name = "publicKeyLab";
            this.publicKeyLab.Size = new System.Drawing.Size(57, 13);
            this.publicKeyLab.TabIndex = 6;
            this.publicKeyLab.Text = "Public Key";
            this.publicKeyLab.Click += new System.EventHandler(this.publicKeyLab_Click);
            // 
            // privateKeyLab
            // 
            this.privateKeyLab.AutoSize = true;
            this.privateKeyLab.Location = new System.Drawing.Point(835, 390);
            this.privateKeyLab.Name = "privateKeyLab";
            this.privateKeyLab.Size = new System.Drawing.Size(61, 13);
            this.privateKeyLab.TabIndex = 7;
            this.privateKeyLab.Text = "Private Key";
            this.privateKeyLab.Click += new System.EventHandler(this.privateKeyLab_Click);
            // 
            // validateKey
            // 
            this.validateKey.Location = new System.Drawing.Point(264, 411);
            this.validateKey.Name = "validateKey";
            this.validateKey.Size = new System.Drawing.Size(81, 23);
            this.validateKey.TabIndex = 8;
            this.validateKey.Text = "Validate Keys";
            this.validateKey.UseVisualStyleBackColor = true;
            this.validateKey.Click += new System.EventHandler(this.validateKey_Click);
            // 
            // createTransation
            // 
            this.createTransation.Location = new System.Drawing.Point(13, 504);
            this.createTransation.Name = "createTransation";
            this.createTransation.Size = new System.Drawing.Size(75, 39);
            this.createTransation.TabIndex = 9;
            this.createTransation.Text = "Create Transaction";
            this.createTransation.UseVisualStyleBackColor = true;
            this.createTransation.Click += new System.EventHandler(this.createTransation_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(95, 549);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(59, 20);
            this.amountBox.TabIndex = 10;
            this.amountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(95, 576);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(59, 20);
            this.feeBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(16, 556);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount";
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(16, 582);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(25, 13);
            this.FeeLabel.TabIndex = 13;
            this.FeeLabel.Text = "Fee";
            // 
            // keyReceiver
            // 
            this.keyReceiver.Location = new System.Drawing.Point(264, 556);
            this.keyReceiver.Name = "keyReceiver";
            this.keyReceiver.Size = new System.Drawing.Size(562, 20);
            this.keyReceiver.TabIndex = 14;
            // 
            // newKeylabel
            // 
            this.newKeylabel.AutoSize = true;
            this.newKeylabel.Location = new System.Drawing.Point(162, 563);
            this.newKeylabel.Name = "newKeylabel";
            this.newKeylabel.Size = new System.Drawing.Size(96, 13);
            this.newKeylabel.TabIndex = 15;
            this.newKeylabel.Text = "New Key Receiver";
            // 
            // GenNewBlock
            // 
            this.GenNewBlock.Location = new System.Drawing.Point(13, 390);
            this.GenNewBlock.Name = "GenNewBlock";
            this.GenNewBlock.Size = new System.Drawing.Size(75, 44);
            this.GenNewBlock.TabIndex = 16;
            this.GenNewBlock.Text = "Generate New Block ";
            this.GenNewBlock.UseVisualStyleBackColor = true;
            this.GenNewBlock.Click += new System.EventHandler(this.GenNewBlock_Click);
            // 
            // pendingTransaction
            // 
            this.pendingTransaction.Location = new System.Drawing.Point(95, 390);
            this.pendingTransaction.Name = "pendingTransaction";
            this.pendingTransaction.Size = new System.Drawing.Size(98, 44);
            this.pendingTransaction.TabIndex = 17;
            this.pendingTransaction.Text = "Read Pending Transactions";
            this.pendingTransaction.UseVisualStyleBackColor = true;
            this.pendingTransaction.Click += new System.EventHandler(this.pendingTransaction_Click);
            // 
            // ReadAll
            // 
            this.ReadAll.Location = new System.Drawing.Point(200, 390);
            this.ReadAll.Name = "ReadAll";
            this.ReadAll.Size = new System.Drawing.Size(58, 44);
            this.ReadAll.TabIndex = 18;
            this.ReadAll.Text = "Read All";
            this.ReadAll.UseVisualStyleBackColor = true;
            this.ReadAll.Click += new System.EventHandler(this.ReadAll_Click_1);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 660);
            this.Controls.Add(this.ReadAll);
            this.Controls.Add(this.pendingTransaction);
            this.Controls.Add(this.GenNewBlock);
            this.Controls.Add(this.newKeylabel);
            this.Controls.Add(this.keyReceiver);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.createTransation);
            this.Controls.Add(this.validateKey);
            this.Controls.Add(this.privateKeyLab);
            this.Controls.Add(this.publicKeyLab);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.publicBox);
            this.Controls.Add(this.genWallet);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.printBotton);
            this.Controls.Add(this.mainTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTextBox1;
        private System.Windows.Forms.Button printBotton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button genWallet;
        private System.Windows.Forms.TextBox publicBox;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.Label publicKeyLab;
        private System.Windows.Forms.Label privateKeyLab;
        private System.Windows.Forms.Button validateKey;
        private System.Windows.Forms.Button createTransation;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox feeBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.TextBox keyReceiver;
        private System.Windows.Forms.Label newKeylabel;
        private System.Windows.Forms.Button GenNewBlock;
        private System.Windows.Forms.Button pendingTransaction;
        private System.Windows.Forms.Button ReadAll;
    }
}

