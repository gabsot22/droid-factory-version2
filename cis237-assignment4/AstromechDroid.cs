/* Gabe Soto
 * CIS 237 MW 6:00-8:15pm
 * 2/19/20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    // To inherit from a class use of a : and then the class name.
    // These are called parent class, or super class, or base class.
    class AstromechDroid : UtilityDroid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private bool fireExtinquisher;
        private int numberShips;

        private const int costPerShip = 3; 

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            // Ask the parent to do the name, type, material, color part by
            // calling ToString on the parent/base class
            return base.ToString();

        }

        // Added this so that we override the virtual method in the parent.
        public override void CalculateTotalCost()
        {
            totalCost = CalculateBaseCost() + TOOL_BOX_CONST + COMPUTER_CONNECTION_CONST + ARM_CONST + FIRE_EXTINGUISHER_CONST + NUMBER_OF_SHIPS_CONST; ;
        }

        //*****************************
        //Constructors
        //*****************************
        public AstromechDroid(
            string Name,
            string Type,
            string Material,
            string Color,
            bool ToolBox,
            bool ComputerConnection,
            bool Arm,
            bool FireExtinquisher,
            int NumberOfShips
        // Call the parent constructor with the base keyword and send it
        // the name, type, material, and color we just collected from the parameters
        // above this comment.
        ) : base(Name, Type, Material, Color, ToolBox, ComputerConnection, Arm)
        {
            // No need to set the name, type, material, color variables.
            // will be handled by the parent/base constructor.
            this.fireExtinquisher = FireExtinquisher;
            this.numberShips = NumberOfShips;
        }
    }
}
