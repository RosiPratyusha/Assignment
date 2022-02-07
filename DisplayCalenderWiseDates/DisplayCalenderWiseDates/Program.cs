using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayCalenderWiseDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            Console.WriteLine("Enter Year in format YYYY ex 2022 :");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month in format M ex 9 :");
            int Month = Convert.ToInt32(Console.ReadLine());
            int current = dayNumber(1, Month, year);
            days = NumberOfDays(Month, year);


            Console.Write("{");

            int k;
            for (k = 0; k < current; k++)
            {
                Console.Write("0");
                Console.Write(",");
            }
                

            for (int j = 1; j <= days; j++)
            {
                
                Console.Write(j);
                Console.Write(",");

                if (++k > 6)
                {
                    k = 0;
                    Console.Write("}");
                    Console.Write("\n");
                    Console.Write("{");
                }
            }
            Console.Write("}");
            Console.ReadLine();
        }
        static int dayNumber(int day, int month, int year)
        {

            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            return (year + year / 4
                    - year / 100
                    + year / 400
                    + t[month - 1] + day)
                   % 7;
        }

        static int NumberOfDays(int monthNumber, int year)
        {
            if (monthNumber == 0)
                return (31);
            if (monthNumber == 1)
            {

                if (year % 400 == 0
                    || (year % 4 == 0
                        && year % 100 != 0))
                    return (29);
                else
                    return (28);
            }
            if (monthNumber == 2)
                return (31);
            if (monthNumber == 3)
                return (31);
            if (monthNumber == 4)
                return (31);
            if (monthNumber == 5)
                return (30);
            if (monthNumber == 6)
                return (31);
            if (monthNumber == 7)
                return (31);
            if (monthNumber == 8)
                return (30);
            if (monthNumber == 9)
                return (31);
            if (monthNumber == 10)
                return (30);
            if (monthNumber == 11)
                return (31);

            return 0;
        }


    }
}

