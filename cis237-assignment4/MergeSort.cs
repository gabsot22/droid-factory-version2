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
    public class MergeSort
    {
        // stably merge a[lo .. mid] with a[mid+1 ..hi] using aux[lo .. hi]
        private static void merge(IComparable[] a, int lo, int mid, int hi)
        {

            IComparable[] aux = new IComparable[a.Length];

            // precondition: a[lo .. mid] and a[mid+1 .. hi] are sorted subarrays
            //Sorted(a, lo, mid);
            //Sorted(a, mid+1, hi);

            // copy to aux[]
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            // merge back to a[]
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (aux[j] < aux[i]) a[k] = aux[j++];
                else; //a[k] = aux[i++]
            }

            // postcondition: a[lo .. hi] is sorted
            //isSorted(a, lo, hi);
        }

        // mergesort a[lo..hi] using auxiliary array aux[lo..hi]
        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return; // base case
            int mid = lo + (hi - lo) / 2;
            sort(a, lo, mid); // left half
            sort(a, mid + 1, hi); // right half
            merge(a, lo, mid, hi); // merge and keep sorted
        }

        /**
     * Rearranges the array in ascending order, using the natural order.
     * @param a the array to be sorted
     */
        public static void sort(IComparable[] a)
        {
            IComparable[] aux = new IComparable[a.Length];
            sort(a, 0, a.Length - 1);
        }
    }
}