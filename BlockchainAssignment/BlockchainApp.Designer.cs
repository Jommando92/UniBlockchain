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
            this.publicKey = new System.Windows.Forms.Label();
            this.privateKey = new System.Windows.Forms.Label();
            this.validateKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.newKeyBox = new System.Windows.Forms.TextBox();
            this.newKeylabel = new System.Windows.Forms.Label();
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
            this.privateBox.Location = new System.Drawing.Point(338, 384);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(488, 20);
            this.privateBox.TabIndex = 5;
            this.privateBox.TextChanged += new System.EventHandler(this.privateBox_TextChanged);
            // 
            // publicKey
            // 
            this.publicKey.AutoSize = true;
            this.publicKey.Location = new System.Drawing.Point(832, 365);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(57, 13);
            this.publicKey.TabIndex = 6;
            this.publicKey.Text = "Public Key";
            this.publicKey.Click += new System.EventHandler(this.label1_Click);
            // 
            // privateKey
            // 
            this.privateKey.AutoSize = true;
            this.privateKey.Location = new System.Drawing.Point(835, 390);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(61, 13);
            this.privateKey.TabIndex = 7;
            this.privateKey.Text = "Private Key";
            this.privateKey.Click += new System.EventHandler(this.label2_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Transaction";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(95, 492);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(59, 20);
            this.amountBox.TabIndex = 10;
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(95, 519);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(59, 20);
            this.feeBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(16, 499);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount";
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(16, 525);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(25, 13);
            this.FeeLabel.TabIndex = 13;
            this.FeeLabel.Text = "Fee";
            // 
            // newKeyBox
            // 
            this.newKeyBox.Location = new System.Drawing.Point(264, 499);
            this.newKeyBox.Name = "newKeyBox";
            this.newKeyBox.Size = new System.Drawing.Size(562, 20);
            this.newKeyBox.TabIndex = 14;
            // 
            // newKeylabel
            // 
            this.newKeylabel.AutoSize = true;
            this.newKeylabel.Location = new System.Drawing.Point(162, 506);
            this.newKeylabel.Name = "newKeylabel";
            this.newKeylabel.Size = new System.Drawing.Size(96, 13);
            this.newKeylabel.TabIndex = 15;
            this.newKeylabel.Text = "New Key Receiver";
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 553);
            this.Controls.Add(this.newKeylabel);
            this.Controls.Add(this.newKeyBox);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.validateKey);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
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
        private System.Windows.Forms.Label publicKey;
        private System.Windows.Forms.Label privateKey;
        private System.Windows.Forms.Button validateKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox feeBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.TextBox newKeyBox;
        private System.Windows.Forms.Label newKeylabel;
    }
}

