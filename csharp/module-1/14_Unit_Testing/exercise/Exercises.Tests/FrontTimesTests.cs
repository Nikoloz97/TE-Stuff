using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class FrontTimesTests
    {
     

        [DataTestMethod]
        [DataRow(null, 3, "")]
        [DataRow("Ab", 3, "AbAbAb")]
        [DataRow("Abc", 4, "AbcAbcAbcAbc")]
        [DataRow("Chocolate", 4, "ChoChoChoCho")]
        [DataRow("", 4, "")]

        public void GenerateStringTest (string str, int n, string expectedOutput)
        {
            FrontTimes frontTimes = new FrontTimes();
            string actualOutput = frontTimes.GenerateString(str, n);
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
