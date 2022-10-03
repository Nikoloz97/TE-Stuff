using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    /*[DataTestMethod]
       [DataRow("Rhino", "Crash")]
       [DataRow("giRaFFe", "Tower")]
       [DataRow("elephant", "Herd")]
       [DataRow("lion", "Pride")]
       [DataRow("crow", "Murder")]
       [DataRow("PIGEoN", "Kit")]
       [DataRow("flamingo", "Pat")]
       [DataRow("deer", "Herd")]
       [DataRow("DOG", "Pack")]
       [DataRow("Crocodile", "Float")]
       [DataRow(null, "unknown")]
       [DataRow("Yo whats up", "unknown")]
       public void GetHerdTest(string animalName, string expectedOutput)

       {
           AnimalGroupName animalGroupName = new AnimalGroupName();

           string actualOutput = animalGroupName.GetHerd(animalName);

           Assert.AreEqual(expectedOutput, actualOutput);*/
    [TestClass()]
    public class Lucky13Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 0, 2, 4 }, true)]
        [DataRow(new int[] { 1, 2, 4 }, false)]
        [DataRow(new int[] { 3, 3, 3 }, false)]
        [DataRow(new int[] { 1, 1, 1 }, false)]
        [DataRow(new int[] {1000000, 1000000, 1182212124}, true)]
        public void GetLuckyTest(int[] nums, bool expectedOutput)
        {
            Lucky13 lucky13Nick = new Lucky13();

            bool actualOutput = lucky13Nick.GetLucky(nums);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
