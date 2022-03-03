using System;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace SHA256Algorithm
{
    class Program
    {
        public string key = "3fb8d408-1ba7-4a02-8812-21104eb51689";
        static void Main(string[] args)
        {

            Console.WriteLine(SHA256Encrypt("maciek123"));
            Console.ReadLine();
        }

        //huQXCamNWjNahye2rjFqjqZ3kqKvTg2jHXAa2gDYrwM=
        public static string SHA256Encrypt(string password)
        {
            byte[] encryptedBytes = null;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var bytesToBeEncrypted = Encoding.UTF8.GetBytes(password);
            var passwordBytes = Encoding.UTF8.GetBytes(new Program().key);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            //var bytesEncrypted = Cipher.Encrypt(bytesToBeEncrypted, passwordBytes);


            return Convert.ToBase64String(bytesToBeEncrypted);
        }
    }
}
