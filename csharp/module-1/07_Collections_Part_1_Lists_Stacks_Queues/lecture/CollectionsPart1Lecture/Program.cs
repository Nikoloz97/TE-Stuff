using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {














			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");


			List<string> names = new List<string>();
		
			names.Add("Frodo");
			names.Add("Jaquan");
			names.Add("Terry");
			


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");


			string[] namesArray = names.ToArray();

            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");



			names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

			

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


			string word = "TechElevator";
			foreach(char letter in word)
            {
                Console.WriteLine(letter);
            }


			List<Dog> dog = new List<Dog>();

			Dog davidsDog = new Dog();
			davidsDog.Name = "Jerry";
			

		}
	}










    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
    }
}
