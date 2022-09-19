using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double

            // User not allowed to add discount greater than 100
            // Need to ask at least once, so use a do-while loop



            double discountAmount = 0;

            do
            {
                Console.Write("Enter the discount amount (w/out percentage): ");
                string input = Console.ReadLine();

                discountAmount = double.Parse(input);


                if (discountAmount > 100)
                {
                    Console.WriteLine("Only enter amounts that are less than 100! Try again.");
                }
            }
            while (discountAmount > 100);


            

            discountAmount /= 100;

            Console.WriteLine("You entered: " + discountAmount);

       


            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): "); // "2.00, 5.00, 10.00"
            string prices = Console.ReadLine();

            Console.WriteLine("You entered: " + prices);

            string[] priceArray = prices.Split(' '); //["2.00", "5.00", "10.00"]




            decimal totalOriginalPrice = 0;
            decimal totalSalePrice = 0;

            for (int i = 0; i < priceArray.Length; i++)
            {
                string value = priceArray[i];
                decimal originalPrice = decimal.Parse(value);
                decimal discountAmountOfItem = originalPrice * (decimal)discountAmount;
                decimal discountedPrice = originalPrice - discountAmountOfItem;

                Console.WriteLine($"Original price: {originalPrice:C2}, amount of discount: {discountAmountOfItem:C2}, sale price: {discountedPrice:C2}.");

                totalOriginalPrice += originalPrice;
                totalSalePrice += discountedPrice;
            }

            Console.WriteLine($"Total Original price: {totalOriginalPrice:C2}, Total Sales Price: {totalSalePrice:C2}");








        }
    }
}
