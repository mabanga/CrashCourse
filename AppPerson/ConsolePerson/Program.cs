using LibraryEntities;
using LibraryEntities.Models;
using LibraryData;
using System;

namespace ConsolePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonAdmin ipa = new Facade().FacadeIPersonAdmin();
            var persons = ipa.InvetoryPersons();
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item}");
            //}
            Person person = new Person()
            {
                Name = new Name("test") { LastName = "rest", SurName = "test" },
                Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" }
            };
            Person pers = new Person()
            {
                Name = new Name("test"),
                Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" }
            };
            //Console.WriteLine("  ---  ");
            ipa.AddPerson(person);
            ipa.AddPerson(pers);
            ipa.AddPerson(new Person() { Address = new Address(), Name = new Name("Ericksson"), Gender=Gender.Male });
            foreach (var item in persons)
            {
                Console.WriteLine($"{item}");

            }

            Console.ReadKey();
        }
    }
}
