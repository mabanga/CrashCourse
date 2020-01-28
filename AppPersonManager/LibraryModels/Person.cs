using System.Text;

namespace LibraryModels
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id \t\t: {ID}");
            sb.AppendLine($"Name \t\t: {Name}");
            return $"{sb}";
        }
    }
}
