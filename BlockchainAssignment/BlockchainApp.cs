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

        private void createTransation_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicBox.Text, keyReceiver.Text, Double.Parse(amountBox.Text), Double.Parse(feeBox.Text), privateBox.Text); // Create a new transaction
            blockchain.transactionPool.Add(transaction); // Add the transaction to the transaction pool
            UpdateText(transaction.ToString()); // Output the transaction to the UI

        }

        private void pendingTransaction_Click(object sender, EventArgs e)
        {
            UpdateText(String.Join("\n", blockchain.transactionPool));
        }

        private void GenNewBlock_Click(object sender, EventArgs e)
        {
            // Retrieve pending transactions to be added to the newly generated Block
            List<Transaction> transactions = blockchain.GetPendingTransactions();
            // Create and append the new block - requires a reference to the previous block, a set of transactions and the miners public address (For the reward to be issued)
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicBox.Text);
            blockchain.blocks.Add(newBlock);
            UpdateText(newBlock.ToString());
        }

        private void ReadAll_Click_1(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());
        }
        private void publicBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void privateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publicKeyLab_Click(object sender, EventArgs e)
        {

        }

        private void privateKeyLab_Click(object sender, EventArgs e)
        {

        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void mainTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.GetBalance(publicBox.Text).ToString() + " Assignment Coin");
        }
    }
}
