using LibraryData.dB;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public class Facade
    {
        public IPersonAdmin FIPersonAdmin()
        {
            return new PersondB();
        }
    }
}
