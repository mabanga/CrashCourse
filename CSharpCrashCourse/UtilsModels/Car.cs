using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsModels
{
    public class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string LicenceNumber { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"LicenceNumber \t: {LicenceNumber}");
            sb.AppendLine($"Make \t\t: {Make}");
            sb.AppendLine($"Color \t\t: {Color}");
            sb.AppendLine($"Year \t\t: {Year}");
            return sb.ToString();
        }
        public Car(string make)
        {
            Make = make;
        }
    }
}
