using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature: ");
            string tempInput = Console.ReadLine();
            double tempInputInt = double.Parse(tempInput);
            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string unitInput = Console.ReadLine();
            char unitInputChar = char.Parse(unitInput);
            char convertedTempUnit = 'C';
            double convertedTemp = 0.0;
            if (unitInputChar == 'C') 
            {
                convertedTempUnit = 'F';
                convertedTemp = Math.Round(((tempInputInt * 1.8) + 32.0), 2);
            }

            if (unitInputChar == 'F') 
            {
                convertedTempUnit = 'C';
                convertedTemp = Math.Round(((tempInputInt - 32.0) / 1.8), 2);
            }
            
            
            Console.WriteLine($"{tempInputInt}{unitInputChar} is {convertedTemp}{convertedTempUnit}.");
        }
    }
}
