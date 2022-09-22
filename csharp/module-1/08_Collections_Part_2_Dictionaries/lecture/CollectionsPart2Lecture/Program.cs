using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			List<string> reviews = new List<string>();

			Dictionary<string, string> nameToZip = new Dictionary<string, string>();
			nameToZip["Nick"] = "44087";
			nameToZip["Eric"] = "44319";



			IEnumerable<string> keys = nameToZip.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key + " lives in: " + nameToZip[key]);
            }

			if(nameToZip.ContainsKey("David"))
            {
                Console.WriteLine("David Exists.");
            }
            Console.WriteLine();

			nameToZip["Nick"] = "12345";

            foreach (KeyValuePair<string, string> nameZipItem in nameToZip)
            {
                Console.WriteLine($"Key:{nameZipItem.Key}, Value: {nameZipItem.Value}");
            }


            Dictionary<string, string> studentNames = new Dictionary<string, string>()
            {
                {"Tracy", "Barry"},
                { "Colin", "Detwiller"},
                {"Maria G",  "Garcia"},
                {"Amy", "Drapac"},
                {"Joe", "Gibson"},
                {"Alex", "Hewson" }
            };


            if (nameToZip.Count < 3)
            {
                Console.WriteLine("name to zip dictionary is small");
            }
            Console.WriteLine("name to zip dictionary is not small");

            foreach (KeyValuePair<string, string> student in studentNames)
            {
                Console.WriteLine(student);
            }






		}
	}
}
