using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Write a  program to print the following pattern:
//
//````
//*
//**
//***
//****
//*****
//````
//
//The number of rows should be based on the value of a variable "num", and the number of stars in a row is based on the row number itself.

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
