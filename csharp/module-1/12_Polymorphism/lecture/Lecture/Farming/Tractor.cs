using System;

namespace Lecture.Farming
{
    class Tractor : ISingable, IDriveable
    {
        public string Sound { get; }
        public string Name { get; }
        public Tractor()
        {
            Name = "Tractor";
            Sound = "Vroom";
        }

        public void Drive()
        {
            Console.WriteLine("Driving my tractor");
        }
    }
}
