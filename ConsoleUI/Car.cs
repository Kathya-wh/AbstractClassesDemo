using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicles
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive!");
        }



    }
}
