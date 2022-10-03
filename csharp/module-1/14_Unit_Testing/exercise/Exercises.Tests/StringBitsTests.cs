using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass()]
    public class StringBitsTests
    {
        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("Hi", "H")]
        [DataRow("", "")]
        [DataRow(null, "")]
        [DataRow("Hello", "Hlo")]

        public void GetBitsTest(string str, string expectedOutput)
        {
            StringBits stringBitsNick = new StringBits();
            string actualOutput = stringBitsNick.GetBits(str);
            Assert.AreEqual(expectedOutput, actualOutput);

        }

    }
}
