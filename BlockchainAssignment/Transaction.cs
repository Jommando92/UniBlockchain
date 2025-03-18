using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        /* Transaction Variables */

        DateTime timestamp; 			// Time of creation
        public String senderAddress, recipientAddress, hash, signature;// Participants public key addresses
        public double amount, fee; 		// Quantities transferred



        /* Transaction Constructor */

        public Transaction(String from, String to, double amount, double fee, String privateKey)
        {
            this.timestamp = DateTime.Now;
            this.senderAddress = from;
            this.recipientAddress = to;
            this.amount = amount;
            this.fee = fee;
            this.hash = CreateHash();						// Hash the transaction attributes
            this.signature = Wallet.Wallet.CreateSignature(senderAddress, privateKey, hash); 		// Sign the hash with the senders private key ensuring validity
        }



        /* Transaction Functions */

        public String CreateHash()						// Hash the transaction attributes using SHA256
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp + senderAddress + recipientAddress + amount + fee; 	// Concatenate all transaction properties
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));	// Apply the hash function to the "input" string
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);					// Reformat to a string
            return hash;
        }



        public override string ToString()						// Represent a transaction as a string for output to UI
        {
            return "  [TRANSACTION START]"
                + "\n  Timestamp: " + timestamp
                + "\n  -- Verification --"
                + "\n  Hash: " + hash
                + "\n  Signature: " + signature
                + "\n  -- Quantities --"
                + "\n  Transferred: " + amount + " Assignment Coin"
                + "\t  Fee: " + fee
                + "\n  -- Participants --"
                + "\n  Sender: " + senderAddress
                + "\n  Reciever: " + recipientAddress
                + "\n  [TRANSACTION END]";
        }
    }
}
//using System;
//using System.Security.Cryptography;
//using System.Text;

//namespace BlockchainAssignment
//{
//    class Transaction
//    {
//        /* Transaction Variables */
//        public readonly DateTime timestamp;  // Time of creation
//        public string senderAddress, recipientAddress, hash, signature; // Participants' public key addresses
//        public double amount, fee;  // Quantities transferred

//        /* Transaction Constructor */
//        public Transaction(string from, string to, double amount, double fee, string privateKey)
//        {
//            timestamp = DateTime.UtcNow;
//            senderAddress = from;
//            recipientAddress = to;
//            this.amount = amount;
//            this.fee = fee;
//            hash = CreateHash();  // Hash the transaction attributes
//            signature = Wallet.Wallet.CreateSignature(senderAddress, privateKey, hash); // Sign the hash
//        }

//        /* Transaction Functions */
//        public string CreateHash() // Hash the transaction attributes using SHA-256
//        {
//            using (SHA256 sha256 = SHA256.Create())
//            {
//                string input = timestamp.ToString("o") + senderAddress + recipientAddress + amount + fee;
//                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
//                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
//            }
//        }

//        public override string ToString() // Represent a transaction as a string for output to UI
//        {
//            return "  [TRANSACTION START]"
//                + "\n  Timestamp: " + timestamp
//                + "\n  -- Verification --"
//                + "\n  Hash: " + hash
//                + "\n  Signature: " + signature
//                + "\n  -- Quantities --"
//                + "\n  Transferred: " + amount + " Assignment Coin"
//                + "\t  Fee: " + fee
//                + "\n  -- Participants --"
//                + "\n  Sender: " + senderAddress
//                + "\n  Receiver: " + recipientAddress
//                + "\n  [TRANSACTION END]";
//        }
//    }
//}
