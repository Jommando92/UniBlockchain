using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            richTextBox1.Text = text;
        }

        // Print Block N (based on user input)


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("Invalid Block No.");
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
