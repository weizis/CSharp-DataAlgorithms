using System;
using System.Collections.Generic;

namespace DataAlgorithms.Sorting
{
    public static class MergeSort
    {
        public static List<T> Sort<T>(
            List<T> list,
            IComparer<T> comparer)
        {
            if (list.Count <= 1)
                return list;

            int mid = list.Count / 2;

            var left = Sort(list.GetRange(0, mid), comparer);
            var right = Sort(list.GetRange(mid, list.Count - mid), comparer);

            return Merge(left, right, comparer);
        }

        private static List<T> Merge<T>(
            List<T> left,
            List<T> right,
            IComparer<T> comparer)
        {
            var result = new List<T>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (comparer.Compare(left[i], right[j]) <= 0)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }
    }
}
