using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace eUseControl.Helpers
{
    public class AES
    {
        private static readonly string key = "your-32-char-aes-key-1234567890123456"; // Exact 32 caractere!

        public static string Encrypt(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            plaintext = sr.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
