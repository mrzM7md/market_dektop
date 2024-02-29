using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.EncryptionDecryption
{
    internal class EncryptionDecryptionText
    {
        internal string Encryption(string planText)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(planText));
        }

        internal string Decryption(string encryptedText)
        { 
            return Encoding.UTF8.GetString(Convert.FromBase64String(encryptedText));
        }
    }
}
