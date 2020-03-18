/* Gabe Soto
 * CIS 237 MW 6:00-8:15pm
 * 3/18/20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment4
{
    public static class MergeSort
    {
        public static void DoMergeSort(this Droid[] droids)
        {
            var sortedDroids = MergeSort(droids);

            for (int i = 0; i < sortedDroids.Length; i++)
            {
                droids[i] = sortedDroids[i];
            }
        }
        private static Droid[] MergeSort(Droid[] droids)
        {
            // Base Case
            if (droids.Length <= 1) return droids;

            // Sub arrays
            var left = new List<Droid>();
            var right = new List<Droid>();

            // Go through everything in Droid[]
            for (int i = 0; i < droids.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(droids[i]);
                }
                else
                {
                    right.Add(droids[i]);
                }

            }

            // Recursion to sort both sublists
            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }

        // Merges the left and right sublists
        private static Droid[] Merge(List<Droid> left, List<Droid> right)
        {
            var result = new List<Droid>();

            //     Not empty        Empty
            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveValueFromSourceToResult(left, result);
                else
                    MoveValueFromSourceToResult(right, right);
            }

            // Either left or right may have elements left
            while (NotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }

            while (NotEmpty(right))
            {
                MoveValueFromSourceToResult(right, result);
            }

            return result.ToArray();
        }

        private static bool NotEmpty(List<Droid> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourceToResult(List<Droid> list, List<Droid> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}


//private static IComparable[] aux = new IComparable[a.length];
//public static void Merge(IComparable a, IComparable[] aux, int lo, int mid, int hi)
//{
//    int k;
//    int i = lo;
//    int j = mid + 1;
//    for (k = lo; k <= hi; k++)
//    {
//        aux[k] = a[k];
//    }
//    for (k = lo; k <= hi; k++)
//    {
//        if (i > mid)
//        {
//            a[k] = aux[j++];
//        }
//        else if (j > hi)
//        {
//            a[k] = aux[i++];
//        }
//        else if (aux[j] < aux[i])
//        {
//            a[k] = aux[j++];
//        }
//        else;
//    }

//}

//// mergesort a[lo..hi] using auxiliary array aux[lo..hi]
//private static void Sort(IComparable[] a, IComparable[] aux, int lo, int hi)
//{
//    // Base Case
//    if (hi <= lo)
//    {
//        return;
//    }
//    int mid = lo + (hi - lo) / 2;
//    // Left half
//    Sort(a, aux, lo, mid);
//    // Right half
//    Sort(a, aux, mid + 1, hi);
//    // Merge and keep sorted
//    Merge(a, aux, lo, mid, hi);
//}







//private static IComparable[] aux;
//public static void Sort(IComparable a)
//{
//    aux = new IComparable[a.length];
//    Sort(a, 0, a.Length - 1);
//}
//private static void Sort(IComparable[] a, int lo, int hi)
//{
//    // Base Case
//    if (hi <= lo)
//    {
//        return;
//    }
//    int mid = lo + (hi - lo) / 2;
//    // Left half
//    Sort(a, lo, mid);
//    // Right half
//    Sort(a, mid + 1, hi);
//    // Merge and keep sorted
//    MergeSort(a, lo, mid, hi);
//}