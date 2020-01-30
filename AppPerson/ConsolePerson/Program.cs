using LibraryEntities;
using LibraryEntities.Models;
using LibraryData;
using System;
using LibraryData.dB;
using System.Collections.Generic;

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

            //Person person = new Person()
            //{
            //    Name = new Name("test") { LastName = "rest", SurName = "test" },
            //    Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" }
            //};
            //Person pers = new Person()
            //{
            //    Name = new Name("test"),
            //    Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" }
            //};
            //Console.WriteLine("  ---  ");

            //CREATE PERSON
            //ipa.AddPerson(person);
            //ipa.AddPerson(pers);
            //ipa.AddPerson(new Person() { Address = new Address(), Name = new Name("Ericksson"), Gender=Gender.Male });
            //PersondB persondB = new PersondB();

            //List<Person> list = persondB._dB;

            //Person pTest = ipa.AddPerson(new Person() { Address = new Address(), Name = new Name("Kasesese"), Gender = Gender.Male });
            //pTest.BirthDate = new DateTime(1000, 01, 01);

            //READ LIST PERSON
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item}");
            //}


            //DELETE PERSON

            //ipa.DeletePerson(pTest.ID);

            //READ LIST PERSON
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //UPDATE PERSON
            //pTest.Name = new Name("Petit Eric");
            //ipa.UpdatePerson(pTest);
            persons.Sort();
            foreach (var item in persons)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("----");
            persons.Reverse();
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name}");
            }
            Console.ReadKey();
        }
    }
}
