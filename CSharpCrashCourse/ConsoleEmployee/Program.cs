using System;
using UtilsLibrary.Models;
using UtilsModels;

namespace ConsoleEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee("  r   e     d    @ g t            ");
            employee.SalaryLevel = 1100;
            employee.Name = "Eric";
            employee.Phone = "0466-020731";

            int SelestedMenu = Utils.GetIntputInt($"0(Quit) - 1(Create employee) - 2(Show Emplyees)");

            switch (SelestedMenu)
            {
                case 0:
                    Console.WriteLine("Bye Bye");
                    break;
                case 1:
                    //employee.
                    //Console.WriteLine("Create Employee");
                    break;
                case 2:
                    Console.WriteLine("Show Employees");
                    break;
            }


            Console.WriteLine(employee);
            if (employee.CalculatedSalary > 20000)
            {
                Console.WriteLine("You are filthy rich");
            }
            else
            {
                Console.WriteLine("see the big boss");
            }
            Console.ReadKey();
        }
    }
}
