using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DeckOfCards.Stubs
{
    class WoodenPencil
    {
        // public = accessible outside of class (i.e. other files)
        public const double DefaultLength = 8.0;
        public const int DefaultShape = 2;
        public const string DefaultHardness = "HB";
        // Color = cannot use const. Instead, uses similar setup: static readonly
        // Static = shared across all members of class
        // ReadOnly = once set, cannot be altered outside of a class (similar to const)
        public static readonly Color DefaultColor = Color.Yellow;
        public const double DefaultStubLength = 2.0;
        public const double DefaultMaxDullness = 0.3;

        // private = only available inside of class (i.e. only in this file)
        private static double stubLength = DefaultStubLength;



        public double Length { get; set; }

    }
}
