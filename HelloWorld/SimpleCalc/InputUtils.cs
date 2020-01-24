using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class InputUtils
    {
        public static decimal GetIntputDecimal(string message)
        {
            decimal number;
            Console.Write(message);
            string numberAsString = Console.ReadLine();
            while (!decimal.TryParse(numberAsString, out number))
            {
                Console.Clear();
                Console.Write("A number: ");
                numberAsString = Console.ReadLine();
            }
            return number;
        }
    }
}
