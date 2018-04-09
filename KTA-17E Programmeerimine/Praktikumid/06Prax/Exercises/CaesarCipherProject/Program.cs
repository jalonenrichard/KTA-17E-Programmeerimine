using System;

namespace CaesarCipherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tegemist on Caesar Cipher programmiga, mis krypteerib voi dekrypteerib sinu sisestatud teksti.");
            Console.WriteLine("Kas soovid teksti krypteerida(1) voi dekrypteerida(2)?");
            Console.Write("Sisesta tekst: ");
            string userInput = Console.ReadLine();
            CaesarCipher caesarCipher = new CaesarCipher();
            Console.WriteLine(caesarCipher.EncryptText(userInput.ToLower(), 3));
            Console.ReadKey();
        }
    }
}
