using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class DateFashionTests
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

        [DataTestMethod]
        [DataRow(5, 10, 2)]
        [DataRow(5, 2, 0)]
        [DataRow(5, 5, 1)]
        [DataRow(10, 0, 0)]
        [DataRow(0, 10, 0)]
        [DataRow(2, 10, 0)]
        [DataRow(10, 2, 0)]
        [DataRow(8, 3, 2)]
        [DataRow(3, 8, 2)]

        public void GetATableTest (int you, int date, int expectedOutput)
        {
            DateFashion dateFashion = new DateFashion();

            int actualOutput = dateFashion.GetATable(you, date);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
