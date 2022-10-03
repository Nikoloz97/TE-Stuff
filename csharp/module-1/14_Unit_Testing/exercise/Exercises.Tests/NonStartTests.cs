using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass()]
    public class NonStartTests
    {
        [DataTestMethod]
        [DataRow("Hello", "There", "ellohere")]
        [DataRow("java", "code", "avaode")]
        [DataRow("shot1", "java", "hot1ava")]
        [DataRow(" Hello", " There", "HelloThere")]
        [DataRow("JAVA", null, "AVA")]
        [DataRow(null, "hey", "ey")]
        [DataRow("", "", "")]
        public void GetPartialStringTest(string a, string b, string expectedOutput)
        {
            NonStart nonStartNick = new NonStart();
            string actualOutput = nonStartNick.GetPartialString(a, b);
            Assert.AreEqual(expectedOutput, actualOutput);
        }


    }
}
