using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string lengthInput = Console.ReadLine();
            double lengthInputDoub = double.Parse(lengthInput);
            Console.WriteLine("Is the temperature in (m)eter, or (f)eet? ");
            string unitInput = Console.ReadLine();
            char unitInputChar = char.Parse(unitInput);
            char convertedLengthUnit = 'm';
            double convertedLength = 0.0;
            if (unitInputChar == 'm')
            {
                convertedLengthUnit = 'f';
                convertedLength = Math.Round(((lengthInputDoub * 3.280399)), 2);
            }

            if (unitInputChar == 'f')
            {
                convertedLengthUnit = 'm';
                convertedLength = Math.Round(((lengthInputDoub * 0.3048)), 2);
            }


            Console.WriteLine($"{lengthInputDoub}{unitInputChar} is {convertedLength}{convertedLengthUnit}.");
        }
    }
}
