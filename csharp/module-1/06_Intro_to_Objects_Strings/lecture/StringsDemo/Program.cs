using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char firstCharacter = name[0];
            char lastCharacter = name[^1];



             Console.WriteLine($"First Character is {firstCharacter} and Last Character is {lastCharacter}.");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3);

             Console.WriteLine($"First 3 characters: {firstThreeCharacters}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace


            string lastThreeChars = name.Substring(9, 3);

             Console.WriteLine($"First and last three characters: {firstThreeCharacters}{lastThreeChars}");

            // 4. What about the last word?
            // Output: Lovelace

            string[] nameArray = name.Split(' ');


             Console.WriteLine($"Last Word: {nameArray[1]}");


            // 5. Does the string contain inside of it "Love"?
            // Output: true


            bool hasLove = name.Contains("Love");

            Console.WriteLine($"Contains \"Love\": {hasLove}");

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int laceLocation = name.IndexOf("lace");

            Console.WriteLine($"Index of \"lace\": {laceLocation}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            string nameLowered = name.ToLower();
            int numberOfAs = 0;
            for (int i = 0; i < nameLowered.Length; i++)
            {
                if (nameLowered[i] == 'a')
                {
                    numberOfAs++;
                }
            }

            Console.WriteLine($"Number of \"a's\": {numberOfAs}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            string nameCountess = name.Replace("Ada", "Ada, Countless of Lovelace");
            
            Console.WriteLine(nameCountess);

            // 9. Set name equal to null.

            name = null;
            bool isNull = (name == null);
            Console.WriteLine($"Is name null now?: {isNull}");

            // 10. If name is equal to null or "", print out "All Done".

            if (name == null || name == "")
            {
                Console.WriteLine("All Done");
            } 
            

            // Or, much simpler... 

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done");
            }
            
        }
    }
}