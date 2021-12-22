using System;
using ExpressEncription;

namespace Security
{
    class Program
    {
        private static void Main(string[] args)
        {
            //RSA Encryption

            //Generate a key pair
            ExpressEncription.RSAEncription.MakeKey(@"D:\Kuliah\Semester 5\Jaringan\Security Case\public.key", @"D:\Kuliah\Semester 5\Jaringan\Security Case\private.key");

            //Encrypt
            var plainText = "Hallo";
            var cypherText = ExpressEncription.RSAEncription.EncryptString(plainText, @"D:\Kuliah\Semester 5\Jaringan\Security Case\public.key");

            //decrypt
            var decyrptText = ExpressEncription.RSAEncription.DecryptString(cypherText, @"D:\Kuliah\Semester 5\Jaringan\Security Case\private.key");

        }
    }
}
