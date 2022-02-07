using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers:");
            int[] num = new int[10];
            int[] res = new int[2];
            for(int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sum sum = new Sum();
            res = sum.sumOfEvensAndOdds(num);
            Console.WriteLine("Sum of Even Numbers and Odd numbers is:" + "{" + res[0] + "," + res[1] + "}");
            Console.ReadLine();
        }
    }
    class Sum
    {
        public int[] sumOfEvensAndOdds(int[] nums)
        {
            // do stuff here
            int evenSum = 0;
            int oddSum = 0;
            int[] res = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                
                if (nums[i] % 2 == 0)
                {
                    evenSum = evenSum + nums[i];
                }
                else
                    oddSum = oddSum + nums[i];
            }
            res[0] = evenSum;
            res[1] = oddSum;
            return res;
        }
    }
    
}
