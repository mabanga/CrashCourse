using LibraryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDLL.Managers
{
    public class PersonManagerFakeDB : IPersonManager
    {
        int _id = 1;
        List<Person> personFakeDB = new List<Person>();

        public Person AddPerson(Person person)
        {
            Person addedPerson;
            personFakeDB.Add(addedPerson=new Person() { Name = $"{person.Name}"});
            person.ID = _id++;

           return addedPerson;
        }

        public List<Person> GetPersons()
        {
            return personFakeDB;
        }


        public PersonManagerFakeDB()
        {
            AddPerson(new Person() { Name = "John" });
            AddPerson(new Person() { Name = "Eric" });
            AddPerson(new Person());
        }
    }
}
