using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> boolAppear = new Dictionary<string, bool>();
            Dictionary<string, int> numbAppear = new Dictionary<string, int>();


            foreach (string word in words)
            {
                if (numbAppear.ContainsKey(word))   numbAppear[word]++;
                else numbAppear[word] = 1;
            }
            foreach (KeyValuePair<string, int> pair in numbAppear)
            {
                if (pair.Value > 1)
                {
                    boolAppear[pair.Key] = true;
                }
                else
                {
                    boolAppear[pair.Key] = false;
                }
                //return boolAppear;

            }
            return boolAppear;

        }
    }
}
