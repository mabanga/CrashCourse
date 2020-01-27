using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsModels;
namespace ConsoleCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota");
            car.Color = "White";
            car.LicenceNumber = "ABC1234";
            Console.WriteLine(car);

            Console.ReadKey();

        }
    }
}
