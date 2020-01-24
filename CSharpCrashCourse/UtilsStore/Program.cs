using System;
using UtilsLibrary.Models;
namespace UtilsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal FDec = Utils.GetIntputDecimal("First number: ");
            decimal SDec = Utils.GetIntputDecimal("Second number: ");

            Console.Clear();
            Console.WriteLine($"you wrote {FDec} and {SDec}");
            Console.WriteLine("The answer:  {0}", FDec + SDec);
            Console.ReadKey();
        }
    }
}
