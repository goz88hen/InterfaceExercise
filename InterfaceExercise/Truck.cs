﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck: IVehicle, ICompany
    {
       
        public Truck()
            {

            }
            public string CompanyName { get; set; } = "Ford";
            public string Motto { get; set; } = "Being Tough";
            public double EngineSize { get; set; } = 8;
            public string Model { get; set; } = "F150";
            public string Make { get; set; } = "Ford";
            public string Year { get; set; } = "2020";
            public int SeatCount { get; set; } = 4;
            public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

            public void Drive()
            {
                 if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");
            }
                 else
            {
                Console.WriteLine($"{GetType().Name} now driving forward... ");
            }

       
            }
            public void Reverse()
            {
                if (HasChangedGears == true)
                {
                    Console.WriteLine($"{GetType().Name} now reversing...");
                    HasChangedGears = false;
                }
                else
                {
                    Console.WriteLine("Can't reverse until changed gears");
                }
            }
            public void Park()
            {
                Console.WriteLine();
            }
            public void ChangeGears(bool isChanged)
            {
                HasChangedGears = isChanged;
            }

        }

    }
    





