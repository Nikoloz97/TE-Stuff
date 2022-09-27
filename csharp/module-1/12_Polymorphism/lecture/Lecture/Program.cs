using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            ISingable[] singables = new ISingable[] { new Cow(), new Chicken(), new Pig(), new Tractor()};

            foreach (ISingable singableThing in singables)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + singableThing.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + singableThing.Sound + " " + singableThing.Sound + " here");
                Console.WriteLine("And a " + singableThing.Sound + " " + singableThing.Sound + " there");
                Console.WriteLine("Here a " + singableThing.Sound + " there a " + singableThing.Sound + " everywhere a " + singableThing.Sound + " " + singableThing.Sound);
                Console.WriteLine();
            }


            ISellable[] sellables = new ISellable[] { new Egg(), new Cow(), new Pig(), new Chicken() };

            foreach (var sellableItem in sellables)
            {
                Console.WriteLine($"Please buy this {sellableItem.Name} for only {sellableItem.Price}");
            }


            Tractor myTractor = new Tractor();
            Truck myTruck = new Truck();
            myTractor.Drive();
            myTruck.Drive();


             List<IDriveable> vehiclesList = new List<IDriveable>();
            vehiclesList.Add(myTractor);
            vehiclesList.Add(myTruck);





        }
    }
}