using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.EncryptionDecryption
{
    internal class EncryptionDecryptionImage
    {
        internal string Encryption(Bitmap image)
        {
            // convert bitmap to byte array
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] b = ms.ToArray();
            
            return Convert.ToBase64String(b);
        }

        internal Image Decryption(string encryptionImageText)
        {
            byte[] bytes = Convert.FromBase64String(encryptionImageText);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
