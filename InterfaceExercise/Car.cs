using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public string CompanyName { get; set; } = "Mercedes Benz";
        public string Motto { get; set; } = "The Best or Nothing";
        public double EngineSize { get; set; } = 2.0;
        public string Model { get; set; }= "E350";
        public string Make { get; set; } = "Mercedes";
        public string Year { get; set; } = "2020";
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
                HasChangedGears= false;
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
    

 