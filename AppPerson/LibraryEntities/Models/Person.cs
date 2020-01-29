using LibraryEntities.Models;
using System;
using System.Text;

namespace LibraryEntities.Models
{
    public class Person
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeadDate { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id \t\t: {ID}");
            sb.AppendLine($"Gender \t\t: {Gender}");
            sb.AppendLine($"Name \t\t: {Name}");
            sb.AppendLine($"Address \t: {Address}");
            sb.AppendLine($"BirthDate \t: {BirthDate}");
            sb.AppendLine($"DeadDate \t: {DeadDate}");
            return $"{sb}";
        }

        public static explicit operator Person(string v)
        {
            throw new NotImplementedException();
        }
    }
}
