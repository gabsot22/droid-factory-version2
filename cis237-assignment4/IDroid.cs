/* Gabe Soto
 * CIS 237 MW 6:00-8:15pm
 * 3/18/20
 * */
using System;

namespace cis237_assignment4
{
    interface IDroid : IComparable
    {
        // calculate the total cost of a droid
        void CalculateTotalCost();

        // Property to get the total cost of a droid
        decimal TotalCost { get; set; }
        
    }
}
