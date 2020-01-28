using LibraryDLL.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDLL
{
    public class Facade
    {
        public IPersonManager GetPersonManager()
        {
            return new PersonManagerFakeDB();
        }
    }
}
