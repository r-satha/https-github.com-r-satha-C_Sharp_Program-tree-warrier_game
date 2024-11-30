using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    class Vehicle : IDrivable
    {
        public string Brand {  get; set; }
        public Vehicle(string brand = "No Brand",
            int wheels = 0,
            double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed  = speed;
        }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        public void move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
        }
        public void stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
