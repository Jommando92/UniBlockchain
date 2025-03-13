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
        public Blockchain()
        {
            this.blocks = new List<Block>();
            Block genesisBlock = new Block(null); // Create the genesis block with no previous block
            this.blocks.Add(genesisBlock);
        }
        public String GetBlockAsString(int index)		// Prints the block at the specified index to the UI
        {
            if (index >= 0 && index < blocks.Count)		// Check if referenced block exists
                return blocks[index].ToString(); 		// Return block as a string
            return "No such block exists";
        }

        public override string ToString()				// Output all blocks of the blockchain as a string
        {
            return String.Join("\n", blocks);
        }


    }

}