using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class TriangleWall : Wall
    {
        public int Base { get; }
        public int Height { get; }

        // notice the syntax - child class constructors need to be followed by: base (base properties)
        public TriangleWall(string name, string color, int @base, int height) : base (name, color)
        {
            Base = @base;
            Height = height;
        }
        
        // children of abstract method need to have override
        public override int GetArea ()
        {
            return (Base * Height) / 2;
        }

        public override string ToString()
        {
            return $"{Name} ({Base}x{Height}) triangle";
        }
    }
}
