using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a function called "sumOfPrimes", that takes two integers as input and returns the sum of all the prime numbers between the same.
//
//````
//public int sumOfPrimes(int from, int to)
//{
//    // do stuff here
//    return 0;
//}
//
//Write a  program to call the above function multiple times with different values.

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter To Number:");
            int to = Convert.ToInt32(Console.ReadLine());
            SumOfPrime sop = new SumOfPrime();
            int sum = sop.sumOfPrimeNumbers(from,to);
            Console.WriteLine("sum of prime numbers from " + from + " to " + to + "is:" + sum);
            Console.ReadLine();
        }
       
    }
    public class SumOfPrime
    {
        public int sumOfPrimeNumbers(int from, int to)
        {
            int sum = 0;
            // do stuff here
            for(int i = from; i <= to; i++)
            {
                int count = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                    count++;
                }
                if(count == 2 || count == 1)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
