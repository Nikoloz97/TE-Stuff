using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass()]

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
    public class Less20Tests
    {
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(18, true)]
        [DataRow(20, false)]
        [DataRow(40, false)]
        [DataRow(19, true)]
        [DataRow(63, false)]
        public void IsLessThanMultipleOf20Test (int n, bool expectedOutput)
        {
            Less20 less20 = new Less20();

            bool acualOutput = less20.IsLessThanMultipleOf20(n);

            Assert.AreEqual(expectedOutput, acualOutput);

        }
    }
}
