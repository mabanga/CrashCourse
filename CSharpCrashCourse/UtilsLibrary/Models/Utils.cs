using System;

namespace UtilsLibrary.Models
{
    public class Utils
    {
        public static decimal GetIntputDecimal(string message)
        {
            decimal number;
            Console.Write(message);
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.Write(message);
            }
            return number;
        }
        public static int GetIntputInt(string message)
        {
            int number;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.Write(message);
            }
            return number;
        }
        public static double GetDoubleputInt(string message)
        {
            double number;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.Write(message);
            }
            return number;
        }
    }
}
