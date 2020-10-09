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
        public string Encode (string msg, int key)
        {
            string result = "";
            
            for (int i = 0; i < msg.Length; i++)
            {
                result += (char)(msg[i] ^ key);
            }
            return result;
        }
    }
}
