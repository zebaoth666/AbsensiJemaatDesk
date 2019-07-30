using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace AbsensiJemaatDesk
{
    public class encryptClass
    {
        //Updated 2107/07/27 -> ga kepake karena ga nemu decrypt nya
        //Example usage: EncryptBytes(someFileBytes, "SensitivesPhrase", "SodiumChloride")
        public static byte[] encryptBytes(byte[] inputBytes, string passPhrase, string salValue) {
            RijndaelManaged ri = new RijndaelManaged();
            ri.Mode = CipherMode.CBC;
            byte[] salt = Encoding.ASCII.GetBytes(salValue);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, salt,"SHA1",2);

            return salt;
        }

        //Updated 2107/07/27
        public static string Encrypt(string plainText,
                                        string passPhrase,
                                        string saltValue,
                                        string hashAlgorithm,
                                        int passwordIterations,
                                        string initVector,
                                        int keySize)
        {
            string cipherText = string.Empty;

            try
            {
                //Create byte arrays of our strings so that we can use them
                //with the .NET Rijndael classes.
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

                PasswordDeriveBytes password = new PasswordDeriveBytes(
                    passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
                byte[] keyBytes = password.GetBytes(keySize / 8);

                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes,
                    initVectorBytes);

                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    encryptor, CryptoStreamMode.Write);

                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                cryptoStream.FlushFinalBlock();

                byte[] cipherTextBytes = memoryStream.ToArray();

                memoryStream.Close();
                cryptoStream.Close();

                cipherText = Convert.ToBase64String(cipherTextBytes);

            }
            catch
            {
                cipherText = string.Empty;
            }

            return cipherText;
        }

        public static string Decrypt(   string cipherText,
                                        string passPhrase,
                                        string saltValue,
                                        string hashAlgorithm,
                                        int passwordIterations,
                                        string initVector,
                                        int keySize)
        {
            string plainText = string.Empty;
 
            try
            {
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
 
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
 
                PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                                passPhrase,
                                                                saltValueBytes,
                                                                hashAlgorithm,
                                                                passwordIterations);
                byte[] keyBytes = password.GetBytes(keySize / 8);
 
                RijndaelManaged symmetricKey = new RijndaelManaged();
 
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                             keyBytes,
                                                             initVectorBytes);
 
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
 
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                              decryptor,
                                                              CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                               0,
                                                               plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
 
                plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                               0,
                                                               decryptedByteCount);
            }
            catch (CryptographicException)
            {
                throw;
            }
 
            return plainText;
        }
    }

        /*
        The plainText can be any string  (something we want to encrypt/decrypt), (parameter password)
        The passPhrase must be a password used to encrypt / decrypt the data. (S@lv4tion)
         * This is a ‘shared secret’ known only between Alice & Bob.
        The saltValue may or may not be a secret between Alice & Bob.  (1)
         * It is combined with the passPhrase in the encryption routine, and can complicate dictionary attacks.
        The hashAlgorithm can be either “SHA1” or “MD5”. (SHA1)
         * This is a one way hash algorithm which turns a string into a hash in which it is proven 
         * to be mathematically impossible (in a reasonable amount of time using current computing power) 
         * to deduce the original string from the hash.
        The passwordIterations field refers to the number of times the password is hashed, (2)
         * this must be the same on encryption and decryption.
        The initVector MUST be a 16 character string of ASCII characters (known to both Alice & Bob). (a-p)
         * This value is used to encrypt the first block of plaintext data, again to complicate the cracking process.
        The keysize refers to the size of the encryption key, in bits. (256)
         * It can be 128, 192, or 256. Longer keys are more secure.
         */
}
