using System;
using System.Collections.Generic;

namespace DataAlgorithms.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(
            IList<T> list,
            IComparer<T> comparer)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (comparer.Compare(list[j], list[j + 1]) > 0)
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    }
                }
            }
        }
    }
}
