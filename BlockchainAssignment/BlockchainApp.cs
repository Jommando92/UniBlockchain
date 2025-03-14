using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        // Create a new instance of the Blockchain class
        private Blockchain blockchain;



        // Constructor
        public BlockchainApp()
        {
            InitializeComponent();
            this.blockchain = new Blockchain();
            UpdateText("New Blockchain Instance Created");
        }

        // Update the text in the textbox
        private void UpdateText(String text)
        {
            mainTextBox1.Text = text;
        }

        // Print Block N (based on user input)

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void printBotton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(inputBox.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("Invalid Block No.");
        }

        private void mainTextBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privKey);
            publicBox.Text = myNewWallet.publicID;
            privateBox.Text = privKey;

        }

        private void validateKey_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateBox.Text, publicBox.Text))
            {
                UpdateText("Keys are valid");
            }
            else
            {
                UpdateText("Keys are invalid");
            }

        }

        private void publicBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void privateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
