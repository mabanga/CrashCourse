using LibraryModels;
using System.Collections.Generic;

namespace LibraryDLL
{
    public interface IPersonManager
    {
        List<Person> GetPersons();
        Person AddPerson(Person person);
        bool DeletePerson(int Id);
    }
}
