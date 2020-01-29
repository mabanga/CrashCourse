using System.Text;

namespace LibraryEntities.Models
{
    public class Name
    {
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{FirstName} {LastName} {SurName}");
            return $"{sb}";
        }
    }
}
