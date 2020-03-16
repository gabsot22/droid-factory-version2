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
    class DroidCollection : UserInterface
    {
        // Private Variables
        private Droid[] droids;
        private int droidLength;

        // Constructor. Must pass the size of the collection
        public DroidCollection(int size)
        {
            this.droids = new Droid[size];
            this.droidLength = 0;
        }

        // Add a new Protocol Droid to the collection
        public void AddNewProtocolDroid(string name, string type, string material, string color, int numOfLanguages)
        {
            droids[droidLength] = new ProtocolDroid(name, type, material, color, 1);
            droidLength++;
        }

        // Add a new Utility Droid to the collection
        public void AddNewUtilityDroid(string name, string type, string material, string color, bool toolBox, bool computerConnection, bool arm)
        {
            droids[droidLength] = new UtilityDroid(name, type, material, color, true, true, true);
            droidLength++;
        }

        // Add a new Janitor Droid to the collection
        public void AddNewJanitorDroid(string name, string type, string material, string color, bool toolBox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            droids[droidLength] = new JanitorDroid(name, type, material, color, true, true, true, true, true);
            droidLength++;
        }

        // Add a new Astromech Droid to the collection
        public void AddNewAstromechDroid(string name, string type, string material, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numOfShips)
        {
            droids[droidLength] = new AstromechDroid(name, type, material, color, true, true, true, true, 1);
            droidLength++;
        }


        // ToString override method to convert the collection to a string
        public override string ToString()
        {
            // Declare a return string
            string returnString = "";

            // Loop through all of the droids
            foreach (Droid droid in droids)
            {
                // If the current beverage is not null, concat it to the return string
                if (droid != null)
                {
                    returnString += droid.ToString() + Environment.NewLine;
                }
            }
        
            // Return the return string
            return returnString;
        }

        public void CategorizeByModel()
        {
            // Make instance of Protocol Droids
            GenericStack<Droid> protocolStackList = new GenericStack<Droid>();
            // Make instance of Utility Droids
            GenericStack<Droid> utilityStackList = new GenericStack<Droid>();
            // Make instance of Janitor Droids
            GenericStack<Droid> janitorStackList = new GenericStack<Droid>();
            // Make instance of Astromech Droids
            GenericStack<Droid> astromechStackList = new GenericStack<Droid>();

            // Pushing Droids
            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    if (droid.GetType() == typeof(ProtocolDroid))
                    {
                        protocolStackList.Push(droid);

                    }

                    if (droid.GetType() == typeof(UtilityDroid))
                    {
                        utilityStackList.Push(droid);

                    }

                    if (droid.GetType() == typeof(JanitorDroid))
                    {
                        janitorStackList.Push(droid);
                    }

                    if (droid.GetType() == typeof(AstromechDroid))
                    {
                        astromechStackList.Push(droid);
                    }
                }
            }
            // Output each stack of Droids
            protocolStackList.Display();
            utilityStackList.Display();
            janitorStackList.Display();
            astromechStackList.Display();

           

            Queue<Droid> queueDroids = new Queue<Droid>();

            // Pop Droids
            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    if (droid.GetType() == typeof(ProtocolDroid))
                    {
                        protocolStackList.Pop(droid);
                        //queueDroids.Enqueue(droid);

                    }

                    if (droid.GetType() == typeof(UtilityDroid))
                    {
                        utilityStackList.Pop(droid);

                    }

                    if (droid.GetType() == typeof(JanitorDroid))
                    {
                        janitorStackList.Pop(droid);
                    }

                    if (droid.GetType() == typeof(AstromechDroid))
                    {
                        astromechStackList.Pop(droid);
                    }

                }
                queueDroids.Enqueue(droid);
                Console.WriteLine("Enqueing");
                Console.WriteLine(droid);
            }

            

        }
    }
}
