using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryEntities.Models
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            //if (x.ID>y.ID)
            //{
            //    return 1;
            //}
            //else if (x.ID < y.ID)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            return x.ID - y.ID;

        }
    }
}
