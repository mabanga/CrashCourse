using System;
using System.Collections.Generic;
using UtilsLibrary.Models;

namespace UtilsModels
{
    public class EmployeeManager
    {
        List<Employee> GetEmployees = new List<Employee>();

        public void CreateEmployee(string email)
        {
            if (email.Trim() == string.Empty || email.Trim() == null)
            {
                email = "Info@zmco.be";
            }
            else
            {
                email = email.Trim(' ').Replace(" ", "");
            }

            Employee empl = new Employee()
            {
                Email = email
            };
            Console.Write($"Name : ");
            empl.Name = Console.ReadLine();
            Console.Write($"Phone : ");
            empl.Phone = Console.ReadLine();
            empl.WeeklyWorkhours = Utils.GetDoubleputInt($"WeeklyWorkHours : ");
            empl.SalaryLevel = Utils.GetIntputInt($"SalaryLevel : ");
            Console.Write($"Department : ");
            empl.Department = Console.ReadLine();
            GetEmployees.Add(empl);
            if (empl.CalculatedSalary > 20000)
            {
                Console.WriteLine("You are filthy rich");
            }
            else
            {
                Console.WriteLine("see the big boss for the salary");
            }
            Console.WriteLine(empl);
        }
        public void PrintAllEmployees()
        {
            foreach (var item in GetEmployees)
            {
                Console.WriteLine(item);
            }
        }
        public EmployeeManager()
        {
        }
    }
}