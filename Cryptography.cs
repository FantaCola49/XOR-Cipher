using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gumming_XOR
{
    class Cryptography
    {
        /// <summary>
        /// Encode your message using key. Key is necessary.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Encode (string msg, long key)
        {
            string result = "";
            
            for (int i = 0; i < msg.Length; i++)
            {
                result += (char)(msg[i] ^ key);
            }
            return result;
        }

        Random rand = new Random();
        private long rnd;

        public Cryptography()
        {
            this.rnd = rand.Next(0, 5000);   
        }

        /// <summary>
        /// Generate random long using XORShift
        /// </summary>
        /// <returns></returns>
        public long getRandom()
        {
            this.rnd ^= (this.rnd << 21);
            this.rnd ^= (this.rnd >> 39);
            this.rnd ^= (this.rnd << 4);
            return this.rnd;
        }
    }
}
