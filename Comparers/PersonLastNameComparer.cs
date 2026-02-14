using System;
using System.Collections.Generic;
using DataAlgorithms.Models;

namespace DataAlgorithms.Comparers
    {
        public class PersonLastNameComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return string.Compare(x?.LastName, y?.LastName);
            }
        }
    }


