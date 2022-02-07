using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseByWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string sentence = Console.ReadLine();
            //Console.WriteLine(sentence[0]);
            //string rev = "";
            ReverseByWords rbw = new ReverseByWords();
            string rev = rbw.reverseByWords(sentence);
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
    class ReverseByWords
    {
        public String reverseByWords(String sentence)
        {
            // do stuff here
            string rev="";
            string word = "";
            for (int i = sentence.Length-1; i >= 0; --i)
            {
                
                if(sentence[i] != ' ')
                {
                   
                        word = word + sentence[i] ;
                    
                }
                if(i == 0 ||sentence[i] == ' ' )
                {
                    rev = rev +' ' + word;
                    word = "";
                }
            }
            return rev;
        }
    }
}
