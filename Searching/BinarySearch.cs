using System;
using System.Collections.Generic;

namespace DataAlgorithms.Searching
{
    public static class BinarySearch
    {
        public static int Search<T>(
            IList<T> list,
            T item,
            IComparer<T> comparer)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int comparison = comparer.Compare(list[middle], item);

                if (comparison == 0)
                    return middle;

                if (comparison > 0)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}
