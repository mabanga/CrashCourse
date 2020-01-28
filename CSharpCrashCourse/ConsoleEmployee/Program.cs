using System;
using UtilsLibrary.Models;
using UtilsModels;

namespace ConsoleEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            int SelestedMenu = -1;
            while (SelestedMenu!=0)
            {
                SelestedMenu = Utils.GetIntputInt($"0(Quit) - 1(Create employee) - 2(Show Emplyees) : ");

                switch (SelestedMenu)
                {
                    case 0:
                        Console.WriteLine("Bye Bye");
                        break;
                    case 1:
                        Console.WriteLine("You are about adding Employee");
                        Console.Write("Typ email: ");
                        string email;
                        employeeManager.CreateEmployee(email = Console.ReadLine());
                        break;
                    case 2:
                        employeeManager.PrintAllEmployees();
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
