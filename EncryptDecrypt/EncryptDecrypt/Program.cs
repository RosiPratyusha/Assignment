using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;

            string newText = Encrypter.Encrypt("Rosi Pratyusha");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            if (debug)
                Console.ReadLine();
        }
    }
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textEncripted += letter.ToString();
            }
            return textEncripted;
        }

        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textDecripted += letter.ToString();
            }
            return textDecripted;
        }
    }
    
}

