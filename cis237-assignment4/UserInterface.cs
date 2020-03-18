/* Gabe Soto
 * CIS 237 MW 6:00-8:15pm
 * 2/19/20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment4
{
    class UserInterface
    {
        const int MAX_MENU_CHOICES = 4;

        //No Variables
        //No Properties
        //No Constructors

        //******************************
        // PUBLIC METHODS
        //******************************

        // Display Welcome Greeting
        public void DisplayWelcomeGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Droid Factory!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display Menu And Get Response
        public int DisplayMenuAndGetResponse()
        {
            // Declare variable to hold the selection
            string selection;

            // Display menu, and prompt
            this.DisplayMenu();
            this.DisplayPrompt();
            
            // Get the selection they enter
            selection = this.GetSelection();

            // While the response is not valid
            while (!this.VerifySelectionIsValid(selection))
            {
                // Display error message
                this.DisplayErrorMessage();

                // Display the prompt again
                this.DisplayPrompt();

                // Get the selection again
                selection = this.GetSelection();
            }
            // Return the selection casted to an integer
            return Int32.Parse(selection);
        }

        // Get Droid Type From The User
        public string GetDroidTypeInformation()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Droid Type:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Janitor ($5) -- Utility ($15) -- Protocol ($25) -- Astromech ($50)");

            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value) &&
                    value == "Protocol" || value == "protocol" ||
                    value == "Utility" || value == "utility" ||
                    value == "Janitor" || value == "janitor" ||
                    value == "Astromech" || value == "astromech")
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a valid Droid Type .");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Enter Droid Type:");
                    Console.WriteLine("Janitor ($5) -- Utility ($15) -- Protocol ($25) -- Astromech ($50)");
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get New Protocol Droid Information From The User.
        public string[] GetNewProtocolDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");
            string material = this.GetMaterialField("Material");
            
            string color = this.GetColorField("Color");
            string numberLanguages = this.GetNumberLanguagesField("Number of Languages");
            

            return new string[] { name, type, material, color, numberLanguages };
        }

        // Get New Utility Droid Information From The User.
        public string[] GetNewUtilityDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");
            string material = this.GetMaterialField("Material");
            string color = this.GetColorField("Color");
            string toolBox = this.GetToolBoxField("Tool Box");
            string computerConnection = this.GetComputerConnectionField("Computer Connection");
            string arm = this.GetArmField("Arm");

            return new string[] { name, type, material, color, toolBox, computerConnection, arm };
        }

        // Get New Janitor Droid Information From The User.
        public string[] GetNewJanitorDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");
            string material = this.GetMaterialField("Material");
            string color = this.GetColorField("Color");
            string toolBox = this.GetToolBoxField("Tool Box");
            string computerConnection = this.GetComputerConnectionField("Computer Connection");
            string arm = this.GetArmField("Arm");
            string trashCompactor = this.GetTrashCompactorField("Trash Compactor");
            string vacuum = this.GetVacuumField("Vacuum");

            return new string[] { name, type, material, color, toolBox, computerConnection, arm, trashCompactor, vacuum };
        }

        // Get New Astromech Droid Information From The User.
        public string[] GetNewAstromechDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");
            string material = this.GetMaterialField("Material");
            string color = this.GetColorField("Color");
            string toolBox = this.GetToolBoxField("Tool Box");
            string computerConnection = this.GetComputerConnectionField("Computer Connection");
            string arm = this.GetArmField("Arm");
            string fireExtinguisher = this.GetFireExtinguisherField("Fire Extinguisher");
            string numOfShips = this.GetNumOfShipsField("Number of Ships");

            return new string[] { name, type, material, color, toolBox, computerConnection, arm, fireExtinguisher, numOfShips };
        }

        // Get New Droid Information From The User.
        public string[] GetNewDroidInformation()
        {
            string name = this.GetNameField("Name");
            string type = this.GetTypeField("Type");
            string material = this.GetMaterialField("Material");
            string color = this.GetColorField("Color");
            
            return new string[] { name, type, material, color };
        }

        

        // Display Header
        public void DisplayDroidHeader()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this.GetDroidHeader());
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

        // Display Add Droid Item Success
        public void DisplayAddDroidItemSuccess()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Droid was successfully added");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display Option 3 Header
        public void DisplayCategorizingHeader()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Categorizing Droids...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        // Display Option 4 Header
        public void DisplaySortingHeader()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorting Droids...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
        // Output for the option 2 
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        // Display New Droid Heading
        public void NewDroidsOutputHeading()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New Droids:");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display PreLoaded Droid heading
        public void PreLoadedDroidsOutputHeading()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pre-loaded Droids:");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Display error message for no new droids
        public void DisplayErrorNoNewDroids()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALERT");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Haven't added any new Droids");
            Console.WriteLine();
        }


        //**********************
        // PRIVATE METHODS
        //**********************
        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print Droid List");
            Console.WriteLine("3. Categorize by Model");
            Console.WriteLine("4. Sort by Total Cost");
            Console.WriteLine("5. Exit");
        }

        // Display the Prompt
        private void DisplayPrompt()
        {
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
        }

        // Display the Error Message
        private void DisplayErrorMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is not a valid option. Please make a valid choice");
        }

        // Get the selection from the user
        private string GetSelection()
        {
            return Console.ReadLine();
        }

        // Verify that a selection from the main menu is valid
        private bool VerifySelectionIsValid(string selection)
        {
            // Declare a returnValue and set it to false
            bool returnValue = false;

            try
            {
                // Parse the selection into a choice variable
                int choice = Int32.Parse(selection);

                // If the choice is between 0 and the maxMenuChoice
                if (choice > 0 && choice <= MAX_MENU_CHOICES)
                {
                    // Set the return value to true
                    returnValue = true;
                }
            }
            // If the selection is not a valid number, this exception will be thrown
            catch (Exception)
            {
                // Set return value to false even though it should already be false
                returnValue = false;
            }

            // Return the reutrnValue
            return returnValue;
        }

        // Get a valid name field from the console
        private string GetNameField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is the new Droid's {0}?", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droid's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid type field from the console
        private string GetTypeField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Confirm Droid's {0}", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Janitor ($5) -- Utility ($15) -- Protocol ($25) -- Astromech ($50)");
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value) &&
                    value == "Protocol" || value == "protocol" ||
                    value == "Utility" || value == "utility" ||
                    value == "Janitor" || value == "janitor" ||
                    value == "Astromech" || value == "astromech")
                { 
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a valid Droid Type.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Confirm Droid's {0}", fieldName);
                    Console.WriteLine("Janitor ($5) -- Utility ($15) -- Protocol ($25) -- Astromech ($50)");
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid material field from the console
        private string GetMaterialField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is the new Droids's {0}", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Iron ($5) -- Gold ($10) -- Amethyst ($15)");
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value) &&
                    value == "Iron" || value == "iron" ||
                    value == "Gold" || value == "gold" ||
                    value == "Amethyst" || value == "amethyst")
                {
                    
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droids's {0}", fieldName);
                    Console.WriteLine("Iron ($5) -- Gold ($10) -- Amethyst ($15)");
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid color field from the console
        private string GetColorField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is the new Droids's {0}", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droids's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get valid decimal field from the user
        private string GetNumberLanguagesField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How many {0} does the Droid have? ($2 per language)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            decimal value = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    value = decimal.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Decimal. Please enter a valid Decimal.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("How many {0} does the Droid have? ($2 per language)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid bool field from the user
        private string GetToolBoxField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid bool field from the user
        private string GetComputerConnectionField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid bool field from the user
        private string GetArmField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "y");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid bool field from the user
        private string GetTrashCompactorField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "y");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid bool field from the user
        private string GetVacuumField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }


        // Get valid bool field from the user
        private string GetFireExtinguisherField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "t" || input.ToLower() == "f")
                {
                    valid = true;
                    value = (input.ToLower() == "t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Does Droid have a {0}? ($1) (T/F)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get valid decimal field from the user
        private string GetNumOfShipsField(string fieldName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} for the Droid ($2)", fieldName);
            Console.ForegroundColor = ConsoleColor.Gray;
            decimal value = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    value = decimal.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Decimal. Please enter a valid Decimal.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("{0} for the Droid ($2)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get a string formatted as a header for items
        private string GetDroidHeader()
        {
            return String.Format("{0,-10} {1,-9} {2,-8} {3,-6} {4, -6} {5, -6}", "Name", "Type", "Material", "Color", "Base Cost", "Total Cost") +
                Environment.NewLine +
                String.Format("{0,-10} {1,-9} {2,-8} {3,-6} {4, -6} {5, -6}", new String('-', 10),
                                                                              new String('-', 9),
                                                                              new String('-', 8),
                                                                              new String('-', 6),
                                                                              new String('-', 9),
                                                                              new String('-', 10));
        }
    }
}
