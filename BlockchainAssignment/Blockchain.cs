using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Blockchain
    {
        public List<Block> blocks;
        private int transactionsPerBlock = 5;				// Maximum number of transactions per block
        public List<Transaction> transactionPool = new List<Transaction>();	// List of pending transactions to be mined

        public Blockchain()
        {
            this.blocks = new List<Block>()
            {
                new Block()
            };

        }
        public String GetBlockAsString(int index)		// Prints the block at the specified index to the UI
        {
            if (index >= 0 && index < blocks.Count)		// Check if referenced block exists
                return blocks[index].ToString(); 		// Return block as a string
            return "No such block exists";
        }

        public Block GetLastBlock()	        		// Retrieves the most recently appended block in the blockchain
        {
            return blocks[blocks.Count - 1];
        }
        public List<Transaction> GetPendingTransactions()			// Retrieve pending transactions and remove from pool
        {
            int n = Math.Min(transactionsPerBlock, transactionPool.Count);	// Determine the number of transactions to retrieve dependent on the number of pending transactions and the limit specified
            List<Transaction> transactions = transactionPool.GetRange(0, n);	// "Pull" transactions from the transaction list (modifying the original list)
            transactionPool.RemoveRange(0, n);
            return transactions;						// Return the extracted transactions
        }

        public override string ToString()				// Output all blocks of the blockchain as a string
        {
            return String.Join("\n", blocks);
        }
        // Check the balance associated with a wallet based on the public key
        public double GetBalance(String address)
        {
            // Accumulator value
            double balance = 0;

            // Loop through all approved transactions in order to assess account balance
            foreach (Block b in blocks)
            {
                foreach (Transaction t in b.transactionList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount; // Credit funds recieved
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee); // Debit payments placed
                    }
                }
            }
            return balance;
        }
    }
}