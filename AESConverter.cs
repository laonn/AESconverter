using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESconverter
{
    internal class AESConverter
    {
        static public byte[] EncryptStringToBytes_Aes(String plainText, byte[] key, byte[] IV)
        {
            if(plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
            if(key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }
            if(IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create()) 
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        static public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }
            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        static public byte[] Padding(byte[] origin, int length)
        {
            byte[] result = new byte[length];

            if(origin.Length > 32)
            {
                throw new Exception("키값이 너무 길어요.");
            }
            else if(origin.Length < 32)
            {
                Array.Copy(origin, result, origin.Length);
                byte padding = (byte)((length - origin.Length) % 8);

                for (int i = origin.Length; i < length; i++)
                {
                    result[i] = padding;
                }
            }
            else
            {
                Array.Copy(origin, result, length);
            }

            return result;
        }
        static public string GetIV() //16자리 숫자 문자열 
        {
            Random random = new Random();
            return random.NextInt64().ToString()[..16];
        }
    }
}
