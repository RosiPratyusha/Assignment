using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a C# program to convert from celsius degrees to Kelvin and Fahrenheit: it will ask the user for the amount of celsius degrees and using the following conversion tables:
//kelvin = celsius + 273
//fahrenheit = celsius x 18 / 10 + 32

namespace ConvertTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius Degrees : ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();
        }
    }
}
