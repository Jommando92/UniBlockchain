using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        private DateTime timestamp; 		// Time of creation
        private int index,
            difficulty = 4;			// Number of leading zeros required in the hash
        public List<Transaction> transactionList;   // List of transactions
        //proof of work
        public long nonce;        // Number use once for proof of work
        public double reward; //simple fixed reward for mining a block
        public String prevHash, hash, merkleRoot, minerAddress;		// A reference pointer to the previous block
        public Block()
        {
            this.index = 0;
            this.timestamp = DateTime.Now;
            this.prevHash = String.Empty;
            this.hash = CreateHash();
            this.transactionList = new List<Transaction>();
            this.hash = Mine();
        }
        public Block(int index, String hash)
        {
            this.index = index + 1;
            this.timestamp = DateTime.Now;
            this.prevHash = hash;
            this.hash = CreateHash();
        }
        public Block(Block prevHash)
        {
            this.timestamp = DateTime.Now;
            this.index = prevHash.index + 1;
            this.prevHash = prevHash.hash;
            this.hash = CreateHash();
        }
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)	// Standard Block
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.minerAddress = minerAddress; 			// The wallet to be credited the reward for the mining effort
            this.reward = 1.0; 					// Assign a simple fixed value reward
            transactions.Add(createRewardTransaction(transactions)); 	// Create and append the reward transaction
            this.transactionList = new List<Transaction>(transactions); 	// Assign provided transactions to the block
            //this.merkleRoot = MerkleRoot(transactionList); 		// Calculate the merkle root of the blocks transactions
            this.hash = Mine(); 					// Conduct PoW to create a hash which meets the given difficulty requirement
        }


        public String CreateHash()						// Hashes the entire Block object
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp.ToString() + index.ToString() + prevHash + nonce + merkleRoot;	// Concatenate all of the blocks properties including nonce as to generate a new hash on each call
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));	// Apply the SHA hash function to the block as represented by the string "input"
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);                 // Reformat to a string
            return hash;
        }
        public String Mine()
        {
            nonce = 0; 				// Initalise the nonce
            String hash = CreateHash();		// Hash the block
            String re = new string('0', difficulty); 	// A string representing the “difficulty” for analysing the PoW requirement
            while (!hash.StartsWith(re)) 		// Check the resultant hash against the "re" string
            {
                nonce++; 			// Increment the nonce should the difficulty level not be satisfied
                hash = CreateHash(); 		// Rehash with the new nonce as to generate a different hash
            }
            return hash;            // Return the hash meeting the difficulty requirement
        }

        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            double fees = transactions.Aggregate(0.0,(amount,t) => amount + t.fee); // Calculate the total fees from the transactions
            return new Transaction("Mine Reward", minerAddress, (reward + fees), 0, ""); // Create a new transaction with the total reward

        }

        public override string ToString()						// Concatenate all properties to output to the UI
        {
            return 
                "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timestamp
                + "\nPrevious Hash: " + prevHash
                + "\n"
                + "\n-- PoW --"
                + "\nDifficulty Level: " + difficulty
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n"
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiners Address: " + minerAddress
                + "\n"
                + "\n-- " + transactionList.Count + " Transactions --"
                + "\nMerkle Root: " + merkleRoot
                + "\n" + String.Join("\n", transactionList)
                + "\n"
                + "\n[BLOCK END]";
        }
    }
}

