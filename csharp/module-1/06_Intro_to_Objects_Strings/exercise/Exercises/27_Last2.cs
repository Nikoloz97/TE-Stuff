﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return the count of the number of times that a substring length 2 appears in the string and
        also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
        Last2("hixxhi") → 1
        Last2("xaxxaxaxx") → 1
        Last2("axxxaaxx") → 2
        */
        public int Last2(string str)
        {
            if ((str.Length - 2) > 0)
            {
                string yellow = str.Substring(((str.Length) - 2), 2);
                int counter = 0;
                for (int i = 0; i < str.Length - 2; i++)
                {
                    if (str[i] == yellow[0] && str[i + 1] == yellow[1])
                    {
                        counter++;
                    }
                }
                return counter;
            }
            return 0;
        }
    }
}
