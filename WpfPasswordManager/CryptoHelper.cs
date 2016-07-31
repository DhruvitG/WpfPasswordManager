using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WpfPasswordManager
{
    class CryptoHelper
    {
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 20; // to match the size of the PBKDF2-HMAC-SHA-1 hash 
        public const int PBKDF2_ITERATIONS = 1000;

        public const int IterationIndex = 0;
        public const int SaltIndex = 1;
        public const int Pbkdf2Index = 2;

        public static byte[] generateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            rng.GetBytes(salt);
            return salt;
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            byte[] hash = GetPbkdf2Bytes(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return hash;
        }

        private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            return pbkdf2.GetBytes(outputBytes);
        }

        public static bool ValidatePassword(string password, string correctHash, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] hash = Convert.FromBase64String(correctHash);

            byte[] testHash = GetPbkdf2Bytes(password, saltBytes, PBKDF2_ITERATIONS, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }
    }       
}
