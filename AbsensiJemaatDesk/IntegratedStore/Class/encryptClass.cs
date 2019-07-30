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
            // Convert strings into byte arrays.
        // Let us assume that strings only contain ASCII codes.
        // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
        // encoding.
        byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
        byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
 
        // Convert our plaintext into a byte array.
        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
 
        // First, we must create a password, from which the key will be derived.
        // This password will be generated from the specified passphrase and 
        // salt value. The password will be created using the specified hash 
        // algorithm. Password creation can be done in several iterations.
        PasswordDeriveBytes password = new PasswordDeriveBytes
        (
            passPhrase,
            saltValueBytes,
            hashAlgorithm,
            passwordIterations
        );
 
        // Use the password to generate pseudo-random bytes for the encryption
        // key. Specify the size of the key in bytes (instead of bits).
        byte[] keyBytes = password.GetBytes(keySize / 8);
 
        // Create uninitialized Rijndael encryption object.
        RijndaelManaged symmetricKey = new RijndaelManaged();
        symmetricKey.Mode = CipherMode.CBC;
 
        // Generate encryptor from the existing key bytes and initialization 
        // vector. Key size will be defined based on the number of the key bytes.
        ICryptoTransform encryptor = symmetricKey.CreateEncryptor
        (
            keyBytes,
            initVectorBytes
        );
 
        // Define memory stream which will be used to hold encrypted data.
        MemoryStream memoryStream = new MemoryStream();
 
        // Define cryptographic stream (always use Write mode for encryption).
        CryptoStream cryptoStream = new CryptoStream
        (
            memoryStream,
            encryptor,
            CryptoStreamMode.Write
        );
 
        // Start encrypting.
        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
 
        // Finish encrypting.
        cryptoStream.FlushFinalBlock();
 
        // Convert our encrypted data from a memory stream into a byte array.
        byte[] cipherTextBytes = memoryStream.ToArray();
 
        // Close both streams.
        memoryStream.Close();
        cryptoStream.Close();
 
        // Convert encrypted data into a base64-encoded string.
        string cipherText = Convert.ToBase64String(cipherTextBytes);
 
        // Return encrypted string.
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
            // Convert strings defining encryption key characteristics into byte arrays. 
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            // Convert our ciphertext into a byte array.
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            // First, we must create a password, from which the key will be 
            // derived. This password will be generated from the specified passphrase and salt value. 
            // The password will be created using the specified hash algorithm. Password creation can be done in several iterations.
            PasswordDeriveBytes password = new PasswordDeriveBytes
            (
                passPhrase,
                saltValueBytes,
                hashAlgorithm,
                passwordIterations
            );

            // Use the password to generate pseudo-random bytes for the encryption
            // key. Specify the size of the key in bytes (instead of bits).
            byte[] keyBytes = password.GetBytes(keySize / 8);

            // Create uninitialized Rijndael encryption object.
            RijndaelManaged symmetricKey = new RijndaelManaged();

            // It is reasonable to set encryption mode to Cipher Block Chaining
            // (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC;

            // Generate decryptor from the existing key bytes and initialization 
            // vector. Key size will be defined based on the number of the key 
            // bytes.
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor
            (
                keyBytes,
                initVectorBytes
            );

            // Define memory stream which will be used to hold encrypted data.
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            // Define cryptographic stream (always use Read mode for encryption).
            CryptoStream cryptoStream = new CryptoStream
            (
                memoryStream,
                decryptor,
                CryptoStreamMode.Read
            );
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            // Start decrypting.
            int decryptedByteCount = cryptoStream.Read
            (
                plainTextBytes,
                0,
                plainTextBytes.Length
            );

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert decrypted data into a string. 
            // Let us assume that the original plaintext string was UTF8-encoded.
            string plainText = Encoding.UTF8.GetString
            (
                plainTextBytes,
                0,
                decryptedByteCount
            );

            // Return decrypted string.   
            return plainText;
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////

        public static string Encrypt2(string key, string data)
        {
            string encData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return encData;
        }

        public static string Decrypt2(string key, string data)
        {
            string decData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return decData;
        }

        private static byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(key);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }

        //source: https://msdn.microsoft.com/de-de/library/system.security.cryptography.aes(v=vs.110).aspx
        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt =
                            new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        //source: https://msdn.microsoft.com/de-de/library/system.security.cryptography.aes(v=vs.110).aspx
        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
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