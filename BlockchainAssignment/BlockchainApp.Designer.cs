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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genWallet = new System.Windows.Forms.Button();
            this.publicBox = new System.Windows.Forms.TextBox();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.publicKey = new System.Windows.Forms.Label();
            this.privateKey = new System.Windows.Forms.Label();
            this.validateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(657, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "PrintNow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // genWallet
            // 
            this.genWallet.Location = new System.Drawing.Point(201, 356);
            this.genWallet.Name = "genWallet";
            this.genWallet.Size = new System.Drawing.Size(68, 47);
            this.genWallet.TabIndex = 3;
            this.genWallet.Text = "Generate Wallet";
            this.genWallet.UseVisualStyleBackColor = true;
            this.genWallet.Click += new System.EventHandler(this.button2_Click);
            // 
            // publicBox
            // 
            this.publicBox.Location = new System.Drawing.Point(276, 356);
            this.publicBox.Name = "publicBox";
            this.publicBox.Size = new System.Drawing.Size(326, 20);
            this.publicBox.TabIndex = 4;
            this.publicBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(276, 383);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(326, 20);
            this.privateBox.TabIndex = 5;
            this.privateBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // publicKey
            // 
            this.publicKey.AutoSize = true;
            this.publicKey.Location = new System.Drawing.Point(608, 364);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(57, 13);
            this.publicKey.TabIndex = 6;
            this.publicKey.Text = "Public Key";
            this.publicKey.Click += new System.EventHandler(this.label1_Click);
            // 
            // privateKey
            // 
            this.privateKey.AutoSize = true;
            this.privateKey.Location = new System.Drawing.Point(611, 389);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(61, 13);
            this.privateKey.TabIndex = 7;
            this.privateKey.Text = "Private Key";
            this.privateKey.Click += new System.EventHandler(this.label2_Click);
            // 
            // validateKey
            // 
            this.validateKey.Location = new System.Drawing.Point(201, 410);
            this.validateKey.Name = "validateKey";
            this.validateKey.Size = new System.Drawing.Size(81, 23);
            this.validateKey.TabIndex = 8;
            this.validateKey.Text = "Validate Keys";
            this.validateKey.UseVisualStyleBackColor = true;
            this.validateKey.Click += new System.EventHandler(this.button3_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.validateKey);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.publicBox);
            this.Controls.Add(this.genWallet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button genWallet;
        private System.Windows.Forms.TextBox publicBox;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.Label publicKey;
        private System.Windows.Forms.Label privateKey;
        private System.Windows.Forms.Button validateKey;
    }
}

