using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hi";
            files[0, 1] = "this";
            files[0, 2] = "is";
            files[0, 3] = "Rosi";
            files[0, 4] = "Pratyusha";

            files[1, 0] = "welcome";
            files[1, 1] = "to";
            files[1, 2] = "RIT";
            files[1, 3] = "Training";
            files[1, 4] = "Session";

            StreamWriter sw = File.CreateText("ArrayToText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + " ");
                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
