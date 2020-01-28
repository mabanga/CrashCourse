using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            int SelectedMenu = GetIntputDecimal("Choose 0(Quit) - 1(Create Employee) - 2(Show Employees): ");
            switch (SelectedMenu)
            {
                case 0:
                    Console.WriteLine("bye bye");
                    break;
                case 1:
                    employeeManager.CreateEmployee("dre@fr.fr");
                    string name;
                    Console.Write($"Name: {name = Console.ReadLine()}");
                    var phone = Console.ReadLine();
                    Console.Write($"Phone: {name}");
                    //Console.WriteLine("Create Employee");
                    //employee
                    break;
                case 2:
                    Console.WriteLine("Show Employees");
                    break;
                default:
                    Console.WriteLine("break bye");
                    break;
            }

            //Employee employee = new Employee("Eric", "zeki@gmail.com", "01234", "Santé", 10, 32.5);
            //Employee employee1 = new Employee("Eric1", "zeki@gmail.com1", "012341", "Santé1", 1, 32.51);
            //Console.WriteLine(employee);
            //if (employee.CalculatedSalary>2000)
            //{
            //    Console.WriteLine($"You are filthy rich");
            //}
            //else
            //{
            //    Console.WriteLine($"Check boos");
            //}
            //Console.WriteLine(employee1);

            Console.ReadKey();
        }
        public static int GetIntputDecimal(string message)
        {
            int number;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.Write(message);
            }
            return number;
        }
    }
}
