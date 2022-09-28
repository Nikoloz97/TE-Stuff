using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    
    // abstract indicates that its children MUST have a GetArea method (otherwise won't work) 
    public abstract class Wall
    {
        public string Name { get; }
        public string Color { get; }

        public Wall(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // abstract methods don't need a body
        public abstract int GetArea();
       




    }
}
