using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsModels
{
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get ; set ; }
        public string Department { get; set; }
        public int SalaryLevel { get; set; }
        public double WeeklyWorkhours { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name \t\t: {Name}");
            sb.AppendLine($"Phone \t\t: {Phone}");
            sb.AppendLine($"Email \t\t: {Email}");
            sb.AppendLine($"Department \t: {Department}");
            sb.AppendLine($"SalaryLevel \t: {SalaryLevel}");
            sb.AppendLine($"WeeklyWorkhours : {WeeklyWorkhours}");
            return sb.ToString();
        }
        public double CalculatedSalary { get {return SalaryLevel*700; } }
        public Employee(string email)
        {
            if (email.Trim() == string.Empty || email.Trim() == null)
            {
                Email = "Info@zmco.be";
            }
            else
            {
                Email = email.Trim(' ').Replace(" ", "");
            }
            //if (CalculatedSalary>20000)
            //{
            //    Console.WriteLine("You are filthy rich");
            //}
            //else
            //{
            //    Console.WriteLine("see the big boss");
            //}
        }
    }
}
