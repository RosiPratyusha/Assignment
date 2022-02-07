using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the body for the following function:
//static boolean isPrimeNumber(int num)
//{
//    return false;
//}
//The function should check and return true only if the number passed as argument is a prime number.
//Write a  program to call the above function multiple times with different values.

namespace isPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = isPrimeNumber(num);
            if (isPrime == true)
                Console.WriteLine(num + " is Prime Number");
            else
                Console.WriteLine(num + " is not a Prime Number");
            Console.ReadLine();
        }
        static bool isPrimeNumber(int num)
        {
            int count = 0;
            for(int i = 2; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
                return true;
            return false;
        }
    }
}
