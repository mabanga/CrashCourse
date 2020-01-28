using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int SalaryLevel { get; set; }
        public double WeeklyWorkHours { get; set; }
        public double CalculatedSalary { get { return SalaryLevel * 700; } }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name \t\t: {Name}");
            sb.AppendLine($"Phone \t\t: {Phone}");
            sb.AppendLine($"Email \t\t: {Email}");
            sb.AppendLine($"Department \t: {Department}");
            sb.AppendLine($"SalaryLevel \t: {SalaryLevel}");
            sb.AppendLine($"SalaryCalcul \t: {CalculatedSalary}");
            sb.AppendLine($"WeeklyWorkHours : {WeeklyWorkHours}");
            return sb.ToString();
        }
        public Employee(string email, string name="noName", string phone="noPhone", string department="noDepartment", int salarylevel=1100, double weeklyworkhours=38)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Department = department;
            SalaryLevel = salarylevel;
            WeeklyWorkHours = weeklyworkhours;
        }
    }
}
