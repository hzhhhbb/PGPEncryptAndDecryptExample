using System;
using PGP.PGP;

namespace PGP
{
    class Program
    {
         static void Main(
            string[] args)
        {
            // 加密文档
            KeyBasedFileProcessor.EncryptFile(@"EncryptedTest.txt", @"test.txt", @"PublicKey.asc", false,true);
            Console.WriteLine("已加密");

            KeyBasedFileProcessor.DecryptFile(@"EncryptedTest.txt", @"PrivateKey.asc",new Char[]{'1','2','3'}, @"DecryptedTest.txt");
            Console.WriteLine("已解密");
            Console.ReadKey();
        }
    }
}

