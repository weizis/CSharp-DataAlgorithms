using System;
using System.Collections.Generic;

namespace DataAlgorithms.Searching
{
    public static class LinearSearch
    {
        public static int Search<T>(
            IList<T> list,
            Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                    return i;
            }
            return -1;
        }
    }
}
