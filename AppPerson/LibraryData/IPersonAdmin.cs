using System;
using System.Collections.Generic;
using System.Text;
using LibraryEntities;
using LibraryEntities.Models;

namespace LibraryData
{
    public interface IPersonAdmin
    {
        List<Person> GetAllPersons();
        Person AddPerson(Person person);
    }
}
