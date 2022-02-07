using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static int fac(int x)
        {
            int i, fac = 1;
            for (i = 1; i <= x; i++)
                fac = fac * i;
            return fac;
        }
        static float pow(float number, int exponent)
        {
            float result = 1;
            while (exponent != 0)
            {
                result *= number;
                --exponent;
            }
            return result;
        }
        static void Main(string[] args)
        {
            float x, Q, sum = 0;
            int i, j, limit;

            Console.WriteLine("Enter value of x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the limit upto which u want to expand : ");
            limit = Convert.ToInt32(Console.ReadLine());
            Q = x;
            x = (float)(x * (3.1415 / 180));

            for (i = 1, j = 1; i <= limit; i++, j = j + 2)
            {
                if (i % 2 != 0)
                {
                    sum = sum + pow(x, j) / fac(j);
                }
                else
                    sum = sum - pow(x, j) / fac(j);
            }

            Console.WriteLine("Sign of x value is : " + Q + ", " + sum);
            Console.ReadLine();
        }
    }
}