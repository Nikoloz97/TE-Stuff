namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {
            if (str.Length % 2 == 0)
            {
                int secondChar = str.Length / 2;
                return $"{str.Substring(secondChar - 1, 1)}{str.Substring(secondChar, 1)}";
            }
            return str;
        }
    }
}
