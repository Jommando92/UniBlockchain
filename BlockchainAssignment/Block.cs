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
        private int index;
        public String prevHash, hash;		// A reference pointer to the previous block
        public Block()
        {
            this.index = 0;
            this.timestamp = DateTime.Now;
            this.prevHash = String.Empty;
            this.hash = CreateHash();
        }
        //public Block(Block prevBlock)
        //{
        //    //this.index = prevBlock.index;
        //    this.timestamp = DateTime.Now;
        //    this.index = prevBlock.index + 1;
        //    this.prevHash = prevBlock.hash;
        //    this.hash = CreateHash();
        //}
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
        public String CreateHash()						// Hashes the entire Block object
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp.ToString() + index.ToString() + prevHash;	// Concatenate all of the blocks properties including nonce as to generate a new hash on each call
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));	// Apply the SHA hash function to the block as represented by the string "input"
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);                 // Reformat to a string
            return hash;
        }
        public override string ToString()						// Concatenate all properties to output to the UI
        {
            return "[BLOCK START]"
                + "\nIndex: " + index.ToString()
                + "\tTimestamp: " + timestamp.ToString()
                + "\nPrevious Hash: " + prevHash
                + "\nHash: " + hash
                + "\n[BLOCK END]";

        }
    }
}

