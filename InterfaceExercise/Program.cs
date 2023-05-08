using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var suv = new SUV();

            var vehicles = new List<IVehicle>() { truck, suv, car };

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                //vehicle.ChangeGears(true);
                vehicle.Reverse();

                Console.WriteLine($"Year: {vehicle.Year}, Make : {vehicle.Make}, Company:{vehicle.CompanyName} , Model : {vehicle.Model}, Engine Size: {vehicle.EngineSize}, Seat Count: {vehicle.SeatCount}");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }  
        }
    }
}

    