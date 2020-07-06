using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE
             * The vehicle class shall have three string properties Year, Make, and Model DONE
             * Set the defaults to something generic in the Vehicle class DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods DONE
             * Only in the Motorcycle class will you override the virtual drive method DONE
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicles>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car explorer = new Car() { HasTrunk = true, Make = "Ford", Model = "Explorer", Year = 2015 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1978 };

            Vehicles sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Caravan", Year = 2019 };
            Vehicles sport = new Car() { HasTrunk = false, Make = "Ferrari", Model = "testarosa", Year = 2000 };


            // can also use: var explorer = new Car() { HasTrunk = true, Make = "Ford", Model = "Explorer", Year = 2015 };
            // can also use: var motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1978 };
            vehicles.Add(explorer);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();
            }
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
