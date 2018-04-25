using System;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "Shrinivas", key = "123@_";
            var encrypted = Cipher.EncryptText(inputText, key);
            Console.WriteLine("Encrpted value : {0} ", encrypted);
            Console.WriteLine("Decrypted value : {0} ", Cipher.DecryptText(encrypted, key));
            Console.ReadKey();
        }
    }
}