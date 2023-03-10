using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of integers, return a List that contains the same integers (as strings). Except any multiple of 3
        must be replaced by the string "Fizz", any multiple of 5 must be replaced by the string "Buzz",
        and any multiple of both 3 and 5 must be replaced by the string "FizzBuzz."
        ** INTERVIEW QUESTION **

        FizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
        FizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "Fizz"]
        FizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]

        HINT: To convert an integer x to a string, you can use x.ToString() in your code. For example, if x = 1 then x.ToString() equals "1."
        */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            List<string> fizzBuzz = new List<string>();
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] % 5 != 0 && integerArray[i] % 3 != 0)
                {
                    fizzBuzz.Add(integerArray[i].ToString());
                }
                if (integerArray[i] % 5 == 0 && integerArray[i] % 3 == 0)
                {
                    fizzBuzz.Add("FizzBuzz");
                    break;
                }
                if (integerArray[i] % 5 == 0)
                {
                    fizzBuzz.Add("Buzz");
                }
                if (integerArray[i] % 3 == 0)
                {
                    fizzBuzz.Add("Fizz");
                }
            }
            return fizzBuzz;
        }
    }
}
