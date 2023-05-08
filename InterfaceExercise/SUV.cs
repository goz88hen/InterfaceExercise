using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        
        public string CompanyName { get; set; } = "Audi";
        public string Motto { get; set; } = "Being Ahead Through Technology";
        public double EngineSize { get; set; } = 0.0;
        public string Model { get; set; } = "E-tron";
        public string Make { get; set; } = "Audi";
        public string Year { get; set; } = "2023";
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
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







