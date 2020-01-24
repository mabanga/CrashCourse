using System;

namespace UtilsLibrary.Models
{
    public class Utils
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
