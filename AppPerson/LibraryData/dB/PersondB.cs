using LibraryEntities;
using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryData.dB
{
    public class PersondB : IPersonAdmin
    {
        private int _id = 1;
        readonly List<Person> _dB = new List<Person>();
        public Person AddPerson(Person person)
        {
            Person addedPerson;
            _dB.Add(addedPerson = new Person()
            {
                Address = person.Address,
                Name = person.Name,
                BirthDate = person.BirthDate,
                Gender = person.Gender,
                ID=_id++
            });
            //File.WriteAllLines(@"C:\Res\Studies\CSharp\CrashCourse\AppPerson\ConsolePerson\bin\Debug\txt.tx",
            //                   //(Person)dB.ToString());
            return addedPerson;
        }

        public List<Person> InvetoryPersons()
        {
            return _dB;
        }

        public bool DeletePerson(int id)
        {
            //foreach (var item in dB)
            //{
            //    if (Person.Id == id)
            //    {
            //        dB.Remove(Person);
            //        return true;
            //    }
            //}
            //return false;
            int count = _dB.RemoveAll(person => person.ID == id);
            return count > 0;
        }

        public Person UpdatePerson(Person person)
        {
            var personFromList=_dB.FirstOrDefault(x => x.ID == person.ID);
            if (personFromList!=null)
            {
                personFromList.Name = person.Name;
                return personFromList;
            }
            return person;

        }

        public PersondB()
        {
            Person eric;
            AddPerson(eric=new Person()
            {
                Address = new Address() { Street = "Ledebaan", HouseNumber = "62", PostBox = "2", ZipCode = "9300", City = "Aalst", Country = "Belgique", Email = "zkm@gmail.com", Phone = "0466/00.00.00" },
                Name = new Name("Eric") {LastName = "Kunga", SurName = "Kadima" },
                BirthDate = new DateTime(1975, 11, 03, 12, 30, 15),
                Gender = Gender.Male
            });
            AddPerson(new Person()
            {
                Address = new Address() { Street = "Ledebaan1", HouseNumber = "621", PostBox = "21", ZipCode = "93001", City = "Aalst1", Country = "Belgique1", Email = "zkm@gmail.com", Phone = "0466/00.00.001" },
                Name = new Name("Eric1") { LastName = "Kunga1", SurName = "Kadima1" },
                BirthDate = new DateTime(1975, 11, 03, 12, 30, 15),
                Gender = Gender.Female
            });
        }
    }
}
