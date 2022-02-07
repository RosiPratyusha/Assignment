using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter index : ");
            int index = Convert.ToInt32(Console.ReadLine()); 
            FibonacciSeries fib = new FibonacciSeries();
            int num = fib.Fibonacci(index);
            Console.WriteLine("Number at index position "+ index + " is:" + num);
            Console.ReadLine();
        }
        
    }
    class FibonacciSeries
    {
        public int Fibonacci(int index)
        {
            // do stuff here
            int first = 0;
            int second = 1;
            int sum = 0;
            int[] fib = new int[10];
            fib[0] = first;
            fib[1] = second;
            for(int i = 2; i <= fib.Length-1; i++)
            {
                sum = first + second;
                fib[i] = sum;
                first = second;
                second = sum;
            }
            return fib[index];
        }
    }
}
