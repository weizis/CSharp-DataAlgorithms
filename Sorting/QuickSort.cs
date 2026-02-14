using System;
using System.Collections.Generic;

namespace DataAlgorithms.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(
            IList<T> list,
            IComparer<T> comparer)
        {
            SortInternal(list, 0, list.Count - 1, comparer);
        }

        private static void SortInternal<T>(
            IList<T> list,
            int low,
            int high,
            IComparer<T> comparer)
        {
            if (low >= high) return;

            int pivotIndex = Partition(list, low, high, comparer);
            SortInternal(list, low, pivotIndex - 1, comparer);
            SortInternal(list, pivotIndex + 1, high, comparer);
        }

        private static int Partition<T>(
            IList<T> list,
            int low,
            int high,
            IComparer<T> comparer)
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (comparer.Compare(list[j], pivot) <= 0)
                {
                    i++;
                    (list[i], list[j]) = (list[j], list[i]);
                }
            }

            (list[i + 1], list[high]) = (list[high], list[i + 1]);
            return i + 1;
        }
    }
}
