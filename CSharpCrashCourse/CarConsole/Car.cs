using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string LicenceNumber { get; set; }
        public string Color { get; set; }

        private void Break()
        {
            Console.WriteLine("eeeehhhheheehehehehehe");
        }
        public void Drive()
        {
            Console.WriteLine("wwwwrrrroooooommmmmmmm");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"LicenceNr \t: {LicenceNumber}");
            sb.AppendLine($"Make \t\t: {Make}");
            sb.AppendLine($"Color \t\t: {Color}");
            sb.AppendLine($"Year \t\t: {Year.ToString()}");
            return sb.ToString();
        }
        public Car(string make, string licencenumber, string color, int year)
        {
            Make = make;
            LicenceNumber = licencenumber;
            Color = color;
            Year = year;
        }
    }
}
