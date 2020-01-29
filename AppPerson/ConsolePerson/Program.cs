using LibraryEntities;
using LibraryEntities.Models;
using System;

namespace ConsolePerson
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { 
            Address= new Address() { Street = "Ledebaan", HouseNumber = "62", PostBox = "2", ZipCode = "9300", City = "Aalst", Country = "Belgique", Email = "zkm@gmail.com", Phone = "0466/00.00.00" },
                Name = new Name() { FirstName = "Eric", LastName = "Kunga", SurName = "Kadima" },
                BirthDate = new DateTime(1975, 11, 03, 12, 30, 15),
                Gender = Gender.Male
            };

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
