using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a C# program to ask the user for 10 real numbers and display the average of the positive ones and the average of the negative ones.


namespace AverageOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[10];
            float SumOfPositiveNum = 0.0f;
            float SumOfNegativeNum = 0.0f;
            int CountPositive = 0;
            int CountNegative = 0;

            Console.WriteLine("Enter 10 Real Numbers: ");
            for(int i =0; i < num.Length; i++)
            {
                num[i] = Convert.ToSingle(Console.ReadLine());
            }
            for(int j = 0; j < num.Length; j++)
            {
                if(num[j] < 0)
                {
                    SumOfNegativeNum = SumOfNegativeNum + num[j];
                    CountNegative++;
                }
                else if(num[j] > 0)
                {
                    SumOfPositiveNum = SumOfPositiveNum + num[j];
                    CountPositive++;
                }
            }
            Console.WriteLine("Average of Entered Positive Numbers is :" + SumOfPositiveNum / CountPositive);
            Console.WriteLine("Average of Entered Negative Numbers is :" + SumOfNegativeNum / CountNegative);
            Console.ReadLine();
        }
    }
}
