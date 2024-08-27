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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            var vehicles = new List<Vehicle>();
            
            var car1 = new Car();
            car1.HasTrunk = false;
            car1.Make = "Ferrari";
            car1.Model = "F430";
            car1.Year = "2008";
            vehicles.Add(car1);
            
            var motorcycle1 = new Motorcycle();
            vehicles.Add(motorcycle1);
            motorcycle1.HasSideCart = false;
            motorcycle1.Make = "Ducati";
            motorcycle1.Model = "Monster 1200";
            motorcycle1.Year = "2018";

            Vehicle newVehicle1 = new Car();
            vehicles.Add(newVehicle1);
            Vehicle newVehicle2 = new Motorcycle();
            vehicles.Add(newVehicle2);
            
            var counter = 0;
            foreach (var vehicle in vehicles)
            {
             Console.WriteLine($"{counter+=1}. {vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

            Console.WriteLine("----------------------------------");
            car1.DriveAbstract();
            car1.DriveVirtual();
            motorcycle1.DriveVirtual();
            motorcycle1.DriveAbstract();
         
        }
    }
}
