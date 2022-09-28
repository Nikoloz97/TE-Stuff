using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Truck : IDriveable
    {
        public string Name { get; }
        public string Sound { get; }

        public Truck()
        {
            Name = "Truck";
            Sound = "Sprt";
        }

        public void Drive()
        {
            Console.WriteLine("Truck yeah");
        }
    }
}
