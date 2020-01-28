using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    public class EmployeeManager
    {
        List<Employee> employeesAsList = new List<Employee>();

        public void CreateEmployee(string email, string name = "noName", string phone = "noPhone", string department = "noDepartment", int salarylevel = 1100, double weeklyworkhours = 38)
        {
            Employee empl = new Employee(email)
            {
                Name = name,
                Phone = phone,
                Department = department,
                SalaryLevel = salarylevel,
                WeeklyWorkHours = weeklyworkhours,
            };
            employeesAsList.Add(empl);
            //Console.WriteLine(" ");

            //Console.WriteLine(empl);
            //Console.WriteLine(" ");
        }
    }
}
