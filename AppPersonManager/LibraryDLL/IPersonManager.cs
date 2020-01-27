using LibraryModels;
using System.Collections.Generic;

namespace LibraryDLL
{
    public interface IPersonManager
    {
        List<Person> GetPersons();

    }
}
