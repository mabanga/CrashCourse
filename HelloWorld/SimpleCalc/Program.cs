using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal FDec;
            decimal SDec;
            Console.Write("First number: ");
            string FNum=Console.ReadLine();
            while (!decimal.TryParse(FNum, out FDec))
            {
                Console.Write("A number: ");
                FNum = Console.ReadLine();
            }
            Console.Write("Second number: ");
            string SNum = Console.ReadLine();
            while (!decimal.TryParse(SNum, out SDec))
            {
                Console.Write("A number: ");
                SNum = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"you wrote {FNum} and {SNum}");
            Console.WriteLine("The answer:  {0}",FDec+SDec);
            Console.ReadKey();
        }

        static decimal checkNumber(string s)
        {
            decimal d = 0.00m;
            //string s = "";
            while (!decimal.TryParse(s, out d))
            {
                Console.Write("A number: ");
                s = Console.ReadLine();
            }
            return d;
        }
    }
}
