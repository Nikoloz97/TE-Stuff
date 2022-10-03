using System.Collections.Generic;

namespace Exercises
{
    public class AnimalGroupName
    {
        public string GetHerd(string animalName)
        {
            Dictionary<string, string> animals = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Pack" },
                {"crocodile", "Float" },
            };

            if (animalName != null && animals.ContainsKey(animalName.ToLower()))
            {
                return animals[animalName.ToLower()];
            }
            else
            {
                return "unknown";
            }
        }
    }
}
