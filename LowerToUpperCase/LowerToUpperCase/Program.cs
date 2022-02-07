using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerToUpperCase
{
    using System;
    using System.IO;

    class FileLowerCaseToUpperCase
    {
        static void Main()
        {
            //Console.Write("Enter name file: ");
            string name = @"C:\Users\Rosi P\source\repos\Resilience2022\SampleConApp-Day8\SampleData.csv";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name +"uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                        
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if(File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}
