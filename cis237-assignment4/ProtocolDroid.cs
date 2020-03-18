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
    // To inherit from a class use of a : and then the class name.
    // These are called parent class, or super class, or base class.
    class ProtocolDroid : Droid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        public int numberLanguages;

        // Constant
        private const int costPerLanguage = 2;

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            // Calculates total cost
            CalculateTotalCost();

            // Ask the parent to do the name, type, material, color part by
            // calling ToString on the parent/base class
            return base.ToString() + " " + totalCost.ToString("C");
        }

        // Added this so that we override the virtual method in the parent.
        public override void CalculateTotalCost()
        {
            totalCost = CalculateBaseCost() + (numberLanguages * costPerLanguage); 
        }

        //*****************************
        //Constructors
        //*****************************
        public ProtocolDroid(
            string Name,
            string Type,
            string Material,
            string Color,
            int NumberLanguages
        // Call the parent constructor with the base keyword and send it
        // the name, type, material, and color we just collected from the parameters
        // above this comment.
        ) : base(Name, Type, Material, Color)
        {
            // No need to set the name, type, material, color variables.
            // will be handled by the parent/base constructor.
            this.numberLanguages = NumberLanguages;
        }


    }
}
