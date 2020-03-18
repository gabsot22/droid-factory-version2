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
            GenericStack<ProtocolDroid> protocolStackList = new GenericStack<ProtocolDroid>();
            // Make instance of Utility Droids
            GenericStack<UtilityDroid> utilityStackList = new GenericStack<UtilityDroid>();
            // Make instance of Janitor Droids
            GenericStack<JanitorDroid> janitorStackList = new GenericStack<JanitorDroid>();
            // Make instance of Astromech Droids
            GenericStack<AstromechDroid> astromechStackList = new GenericStack<AstromechDroid>();

            // Pushing Droids
            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    if (droid.GetType() == typeof(ProtocolDroid))
                    {
                        protocolStackList.Push((ProtocolDroid)droid);

                    }

                    if (droid.GetType() == typeof(UtilityDroid))
                    {
                        utilityStackList.Push((UtilityDroid)droid);
                    }

                    if (droid.GetType() == typeof(JanitorDroid))
                    {
                        janitorStackList.Push((JanitorDroid)droid);
                    }

                    if (droid.GetType() == typeof(AstromechDroid))
                    {
                        astromechStackList.Push((AstromechDroid)droid);
                    }
                }
            }
            Console.WriteLine("Pushing this");
            Console.WriteLine("----------------------------");
            // Output each stack of Droids
            protocolStackList.Display();
            utilityStackList.Display();
            janitorStackList.Display();
            astromechStackList.Display();
            Console.WriteLine("----------------------------");


            // QUEUE DROIDS IN ORDER OF ASTROMECH, JANITOR, UTILITY, PROTOCOL
            Queue<Droid> queueDroids = new Queue<Droid>();

            while (!astromechStackList.IsEmpty)
            {
                queueDroids.Enqueue(astromechStackList.Pop());
            }
            while (!janitorStackList.IsEmpty)
            {
                queueDroids.Enqueue(janitorStackList.Pop());
            }
            while (!utilityStackList.IsEmpty)
            {
                queueDroids.Enqueue(utilityStackList.Pop());
            }
            while (!protocolStackList.IsEmpty)
            {
                queueDroids.Enqueue(protocolStackList.Pop());
            }

            //MergeSort merge = new MergeSort();
            //merge.Sort(queueDroids);

            int index = 0;
            // DEQUEUE DROIDS
            while (queueDroids.Count > 0)
            {

                Console.WriteLine(queueDroids.Dequeue());
                Console.WriteLine($"Number of Droid's left = {queueDroids.Count}");
                //Copy dequeue'd droid to exising array with index of 0, then accumulated
                queueDroids.CopyTo(droids[index]);
                index++;
            }

            


            // Convert Queue into array
            //Droid[] categorizedDroids = queueDroids.ToArray();

            // Displays values of new array
            Console.WriteLine();
            Console.WriteLine("Categorized array:");
            PrintDroids(droids);



            //MergeSort merge = new MergeSort();
            //merge.Sort(queueDroids);

        }
        private static void PrintDroids(Array newdroids)
        {
            foreach(Droid droid in newdroids)
            {
                Console.WriteLine("{0}", newdroids);
            }
        }
    }
    
}
