using EncapsulationLecture.Classes;
using System;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person david = new Person(1989);
            Dog davidsDog = new Dog("Jerry", "Shepard-Mix", false);
            Dog charliesDog = new Dog("Snoopy", "Beagle", false);
/*            Dog emptyDog = new Dog();
*/
            davidsDog.SpeakSound = "Ruff!";

            davidsDog.Speak();
            charliesDog.Speak();
            charliesDog.Speak("grr");



        }
    }
}
