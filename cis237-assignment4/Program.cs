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
    class Program
    {
        static void Main(string[] args)
        {


            // Set a constant for the size of the droidCollection
            const int droidCollectionSize = 100;

            // Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            // Create an instance of the DroidCollection class
            DroidCollection droidCollection = new DroidCollection(droidCollectionSize);

            droidCollection.AddNewProtocolDroid("C3PO", "Protocol", "Gold", "Gold", 5);
            droidCollection.AddNewUtilityDroid("BD1", "Utility", "Amethyst", "Red", true, true, true);
            droidCollection.AddNewAstromechDroid("R2D2", "Astromech", "Iron", "Blue", true, true, true, true, 1);
            droidCollection.AddNewJanitorDroid("A1Z4", "Janitor", "Iron", "Black", true, true, true, true, true);
            droidCollection.AddNewProtocolDroid("P0L0", "Protocol", "Amethyst", "Purple", 3);

            // array to hold pre-loaded droids
            //droids[0] = new ProtocolDroid("C3PO", "Protocol", "Gold", "Gold", 5);
            //droids[1] = new UtilityDroid("BD1", "Utility", "Amethyst", "Red", true, true, true);
            //droids[2] = new AstromechDroid("R2D2", "Astromech", "Iron", "Blue", true, true, true, true, 1);
            //droids[3] = new JanitorDroid("A1Z4", "Janitor", "Iron", "Black", true, true, true, true, true);
            //droids[4] = new ProtocolDroid("P0L0", "Protocol", "Amethyst", "Purple", 3);

            // Display the Welcome Message to the user
            ui.DisplayWelcomeGreeting();

            // Display the Menu and get the response. Store the response in the choice integer
            // This is the 'primer' run of displaying and getting.
            int choice = ui.DisplayMenuAndGetResponse();

            // While the choice selected is not, continue to do work
            while (choice != 5)
            {
                switch (choice)
                {
                    // Add A New Droid To The List
                    case 1:
                        // User Interface gets the droid type
                        string type = ui.GetDroidTypeInformation();
                        
                        // Tests if type is protocol, utility, janitor, or astromech
                        if (type == "Protocol" || type == "protocol")
                        {
                            // Calls the UI for new Droid info and sets it to an array string
                            string[] newDroidInformation = ui.GetNewProtocolDroidInformation();
                            // Adds the new droid to the droidCollection class
                            droidCollection.AddNewProtocolDroid(newDroidInformation[0],
                                                                newDroidInformation[1],
                                                                newDroidInformation[2],
                                                                newDroidInformation[3],
                                                                int.Parse(newDroidInformation[4]));

                            // Display add droid succession
                            ui.DisplayAddDroidItemSuccess();
                        }
                        if (type == "Utility" || type == "utility")
                        {
                            // Calls the UI for new Droid info and sets it to an array string
                            string[] newDroidInformation = ui.GetNewUtilityDroidInformation();

                            // Adds the new droid to the droidCollection class
                            droidCollection.AddNewUtilityDroid(newDroidInformation[0],
                                                               newDroidInformation[1],
                                                               newDroidInformation[2],
                                                               newDroidInformation[3],
                                                               bool.Parse(newDroidInformation[4]),
                                                               bool.Parse(newDroidInformation[5]),
                                                               bool.Parse(newDroidInformation[6]));
                            // Display add droid succession
                            ui.DisplayAddDroidItemSuccess();
                            // Boolean for option 2
                        }
                        if (type == "Janitor" || type == "janitor")
                        {
                            // Calls the UI for new Droid info and sets it to an array string
                            string[] newDroidInformation = ui.GetNewJanitorDroidInformation();

                            // Adds the new droid to the droidCollection class
                            droidCollection.AddNewJanitorDroid(newDroidInformation[0],
                                                               newDroidInformation[1],
                                                               newDroidInformation[2],
                                                               newDroidInformation[3],
                                                               bool.Parse(newDroidInformation[4]),
                                                               bool.Parse(newDroidInformation[5]),
                                                               bool.Parse(newDroidInformation[6]),
                                                               bool.Parse(newDroidInformation[7]),
                                                               bool.Parse(newDroidInformation[8]));
                            // Display add droid succession
                            ui.DisplayAddDroidItemSuccess();
                        }
                        if (type == "Astromech" || type == "astromech")
                        {
                            // Calls the UI for new Droid info and sets it to an array string
                            string[] newDroidInformation = ui.GetNewAstromechDroidInformation();

                            // Adds the new droid to the droidCollection class
                            droidCollection.AddNewAstromechDroid(newDroidInformation[0],
                                                               newDroidInformation[1],
                                                               newDroidInformation[2],
                                                               newDroidInformation[3],
                                                               bool.Parse(newDroidInformation[4]),
                                                               bool.Parse(newDroidInformation[5]),
                                                               bool.Parse(newDroidInformation[6]),
                                                               bool.Parse(newDroidInformation[7]),
                                                               int.Parse(newDroidInformation[8]));
                            // Display add droid succession
                            ui.DisplayAddDroidItemSuccess();

                        }
                        break;

                    // Print Droid List
                    case 2:
                            // Output New Droid heading
                            ui.NewDroidsOutputHeading();

                            // Output Heading
                            ui.DisplayDroidHeader();

                            // Output New Droids 
                            ui.Output(droidCollection.ToString());
                        break;

                    // Categorize by model
                    case 3:
                        // Output Categorizing Header
                        ui.DisplayCategorizingHeader();

                        // Output Heading
                        ui.DisplayDroidHeader();

                        droidCollection.CategorizeByModel();
                        break;

                    // Sort by Total Cost 
                    case 4:
                        MergeSort merge = new MergeSort();

                        // Output Sorting Header
                        ui.DisplaySortingHeader();

                        droidCollection.SendToMerge();

                        break;
                }
                // Get the new choice of what to do from the user
                choice = ui.DisplayMenuAndGetResponse();
            }

        }
    }
}
