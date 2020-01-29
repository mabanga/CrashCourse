using System.Text;
//using LibraryEntities.Inter

namespace LibraryEntities.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostBox { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Street} {HouseNumber}/{PostBox} {ZipCode} {City} {Country} {Phone} {Email} {Fax}");
            return $"{sb}";
        }
    }
}
