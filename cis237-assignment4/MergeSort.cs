using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment4
{
    class MergeSort
    {
        //private static IComparable[] aux = new IComparable[a.length];
        //public static void Merge(IComparable a, int lo, int mid, int hi)
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

        // SECOND TEST
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
        //       return;
        //    }
        //    int mid = lo + (hi - lo) / 2;
        //    Sort(a, lo, mid);
        //    Sort(a, mid + 1, hi);
        //    MergeSort(a, lo, mid, hi);
        //}
    }
}
