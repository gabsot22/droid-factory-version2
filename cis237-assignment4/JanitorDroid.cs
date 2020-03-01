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
    class JanitorDroid : UtilityDroid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private bool trashCompactor;
        private bool vacuum;

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
            totalCost = CalculateBaseCost() + TOOL_BOX_CONST + COMPUTER_CONNECTION_CONST + ARM_CONST + TRASH_COMPACTOR_CONST + VACUUM_CONST;
        }

        //*****************************
        //Constructors
        //*****************************
        public JanitorDroid(
            string Name,
            string Type,
            string Material,
            string Color,
            bool ToolBox,
            bool ComputerConnection,
            bool Arm,
            bool TrashCompactor,
            bool Vacuum
        // Call the parent constructor with the base keyword and send it
        // the name, type, material, and color we just collected from the parameters
        // above this comment.
        ) : base(Name, Type, Material, Color, ToolBox, ComputerConnection, Arm)
        {
            // No need to set the name, type, material, color variables.
            // will be handled by the parent/base constructor.
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
        }
    }
}
