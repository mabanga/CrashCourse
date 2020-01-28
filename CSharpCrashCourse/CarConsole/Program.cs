using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car("Toyota", "abc1234", "red",2001);
            //theCar.Color = "red";
            //theCar.LicenceNumber = "abc1234";
            //theCar.Make = "Toyota";
            //theCar.Year = 2001;

            theCar.Drive();

            Console.WriteLine(theCar.ToString());

            Console.ReadKey();
        }
    }
}
