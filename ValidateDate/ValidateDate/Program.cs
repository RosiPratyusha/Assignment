using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the body for the following function:
//static boolean isValidDate(int year, int month, int day)
//{
//    // do stuff here
//    return false;
//}

//The function should check if the parameter values constitute a valid calendar date or not.Accordingly return true or false.
//For example,
//1) year=2018, month=13, day=1 is an invalid date as the possible values for month is 1 to 12.
//2) year=2018, month=2, day=29 is an invalid date as the maximum days in February is 28 in the year 2018
//3) year=2016, month=2, day=29 is a valid date.
//Write a  program to call the above function multiple times with different values.

namespace ValidateDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Day:");
            int d = Convert.ToInt32(Console.ReadLine());

            bool result = isValidDate(y,m,d);
            if (result == true)
                Console.WriteLine(d + "/" + m + "/" + y + " is valid");
            else
                Console.WriteLine(d + "/" + m + "/" + y + " is not valid");
            Console.ReadLine();

        }
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) &&
                     (year % 100 != 0)) ||
                     (year % 400 == 0));
        }
        static bool isValidDate(int year, int month, int day)
        {
            // do stuff here
            const int MAX_VALID_YR = 9999;
            const int MIN_VALID_YR = 1800;

            if (year > MAX_VALID_YR ||year < MIN_VALID_YR)
            {
                Console.WriteLine("Year should be between 1800 to 9999");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Month should be between 1 and 12");
                return false;
            }
                
            if (month == 2)
            {
                if (isLeap(year))
                {
                    if (day < 1 || day > 29)
                    {
                        Console.WriteLine("Possible values for leap year are 1 to 29");
                        return false;
                    }
                }
                else 
                {
                    if(day < 1 || day > 28)
                    {
                        Console.WriteLine("Possible values for non leap year are 1 to 28");
                        return false;
                    }
                   
                }    
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day < 1 || day > 30)
                {
                    Console.WriteLine("the possible values for month" + month + "is 1 to 30");
                    return false;
                }
            }
            else if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("the possible values for month" + month + "is 1 to 31");
                    return false;
                }   
            }
            return true;
        }
    }
    
}
