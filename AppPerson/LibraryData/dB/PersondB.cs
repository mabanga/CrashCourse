using LibraryEntities;
using LibraryEntities.Models;
using System;
using System.Collections.Generic;

namespace LibraryData.dB
{
    public class PersondB : IPersonAdmin
    {
        private int _id = 1;
        List<Person> dB = new List<Person>();
        public Person AddPerson(Person person)
        {
            Person addedPerson;
            dB.Add(addedPerson = new Person()
            {
                Address = person.Address,
                Name = person.Name,
                BirthDate = person.BirthDate,
                Gender = person.Gender,
                ID=_id++
            });
            return addedPerson;
        }

        public List<Person> InvetoryPersons()
        {
            return dB;
        }
        public PersondB()
        {
            AddPerson(new Person()
            {
                Address = new Address() { Street = "Ledebaan", HouseNumber = "62", PostBox = "2", ZipCode = "9300", City = "Aalst", Country = "Belgique", Email = "zkm@gmail.com", Phone = "0466/00.00.00" },
                Name = new Name() { FirstName = "Eric", LastName = "Kunga", SurName = "Kadima" },
                BirthDate = new DateTime(1975, 11, 03, 12, 30, 15),
                Gender = Gender.Male
            });
            AddPerson(new Person()
            {
                Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" },
                Name = new Name() { FirstName = "Eric1", LastName = "Kunga1", SurName = "Kadima1" },
                BirthDate = new DateTime(1975, 11, 03, 12, 30, 15),
                Gender = Gender.Female
            });
        }
    }
}
