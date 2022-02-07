using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a function called "sortThreeNumbers", which takes 3 distinct integers and prints them in ascending order.
//public void sortThreeNumbers(int a, int b, int c)
//{
//    // do stuff here
//}
//For example,
//
//* sortThreeNumbers(2, 10, 1); // prints 1, 2, 10 
//* sortThreeNumbers(20, 10, 1); // prints 1, 10, 20 
//* sortThreeNumbers(2, 10, 100); // prints 2, 10, 100 and so on.
//
//Write a  program to call the above function multiple times with different values.

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.WriteLine("Enter Three Numbers:");
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort sort = new Sort();
            sort.sortThreeNumbers(num[0],num[1],num[2]);
            Console.ReadLine();
        }
    }
    class Sort
    {
        public void sortThreeNumbers(int a, int b, int c)
        {
            // do stuff here
            int min = a;
            int max = c;
            if (a >= b && c < a)
            {
                if (b > c)
                {
                    Console.WriteLine( c +" "+ b+" "  + a);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            if (c >= b && a <= c)
            {
                if (b > a)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else    // a > b
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
            }
            if (b > a && c < b)
            {
                if (a > c)
                {
                    Console.WriteLine(c + " " + a + " " + a);
                }
                else   // a < c
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }

            }
    }
}
