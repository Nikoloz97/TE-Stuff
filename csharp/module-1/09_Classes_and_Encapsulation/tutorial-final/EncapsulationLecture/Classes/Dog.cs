using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.Classes
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string color { get; set; }

        private bool isSpade { get; set; }

        private string speakSound { get; set; }

        public string SpeakSound 
        { 
            set
            {
                this.speakSound = value;
            }


                }

        public Dog()
        {
            Console.WriteLine("Inside Dog Constructor");
        }

        public Dog (string name, string breed, bool isSpade)
        {
            // this = tell system to refer to object (optional - benefit of making it clear)
            this.Name = name;
            Breed = breed;
            // here, "this" is required (since property and argument names = exactly the same, need to specify which object to refer to)
            this.isSpade = isSpade;
        }
                                 
        
        //Behaviors = things the Dog can do
        public void Speak()
        {
            Console.WriteLine($"{this.Name} says {this.speakSound}");
        }

        public void Speak(string sound)
        {
            Console.WriteLine($"{this.Name} says {sound}");
        }
    }
}
