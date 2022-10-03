﻿using System.Collections.Generic;

namespace Exercises
{
    public class WordCount
    {
        /*
        * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
        * number of times that string appears in the array.
        *
        * ** A CLASSIC **
        *
        * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
        * GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
        * GetCount([]) → {}
        * GetCount(["c", "b", "a"]) → {"c": 1, "b": 1, "a": 1}
        *
        */
        public Dictionary<string, int> GetCount(string[] words)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!output.ContainsKey(word))
                {
                    output[word] = 1;
                }
                else
                {
                    output[word] = output[word] + 1;
                }
            }

            return output;
        }



        /*string actualResult1 = animalGroupName.GetHerd("Rhino");
             string actualResult2 = animalGroupName.GetHerd("giRaFFe");
             string actualResult3 = animalGroupName.GetHerd("elephant");
             string actualResult4 = animalGroupName.GetHerd("lion");
             string actualResult5 = animalGroupName.GetHerd("crow");
             string actualResult6 = animalGroupName.GetHerd("pigeon");
             string actualResult7 = animalGroupName.GetHerd("flamingo");
             string actualResult8 = animalGroupName.GetHerd("deer");
             string actualResult9 = animalGroupName.GetHerd("Dog");
             string actualResult10 = animalGroupName.GetHerd("Crocodile");
             string actualResult11 = animalGroupName.GetHerd(null);
             string actualResult12 = animalGroupName.GetHerd("Yo whats up");
*/

        /*Assert.AreEqual("Crash", actualResult1);
        Assert.AreEqual("Tower", actualResult2);
        Assert.AreEqual("Herd", actualResult3);
        Assert.AreEqual("Pride", actualResult4);
        Assert.AreEqual("Murder", actualResult5);
        Assert.AreEqual("Kit", actualResult6);
        Assert.AreEqual("Pat", actualResult7);
        Assert.AreEqual("Herd", actualResult8);
        Assert.AreEqual("Pack", actualResult9);
        Assert.AreEqual("Float", actualResult10);
        Assert.AreEqual("unknown", actualResult11);
        Assert.AreEqual("unknown", actualResult12);*/

        // Do one for null, unknown (and this doesn't apply here, but the lower and upper bounds)

    }
}
