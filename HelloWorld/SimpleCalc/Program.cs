﻿using System;


namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal FDec;
            decimal SDec;

            FDec = InputUtils.GetIntputDecimal("First number: ");
            SDec = InputUtils.GetIntputDecimal("Second number: ");

            Console.Clear();
            Console.WriteLine($"you wrote {FDec} and {SDec}");
            Console.WriteLine("The answer:  {0}",FDec+SDec);
            Console.ReadKey();
        }
    }
}
