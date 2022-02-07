using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to ask the user for a number and display its multiplication table, using a "while" statement. The result must be like this:
//5 x 1 = 5
//5 x 2 = 10
//5 x 3 = 15

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(num + "X" + i + "=" + num*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
