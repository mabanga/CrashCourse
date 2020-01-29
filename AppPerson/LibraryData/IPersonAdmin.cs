using LibraryEntities.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface IPersonAdmin
    {
        List<Person> InvetoryPersons();
        Person AddPerson(Person person);
    }
}
