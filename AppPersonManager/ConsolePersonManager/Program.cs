
using LibraryDLL;
using LibraryModels;
using System;
namespace ConsolePersonManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            Console.WriteLine(person);

            //IPersonManager pm=new 

            Console.ReadKey();
        }
    }
}
