
using LibraryDLL;
using LibraryModels;
using System;
namespace ConsolePersonManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Name = "John";
            //Console.WriteLine(person);

            IPersonManager pm = new Facade().GetPersonManager();
            var persons = pm.GetPersons();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }

            pm.DeletePerson(0);
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
