using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{

    [TestClass()]
    public class CigarPartyTests
    {
        [DataTestMethod]
        [DataRow(50, false, true)]
        [DataRow(40, false, true)]
        [DataRow(40, true, true)]
        [DataRow(60, false, true)]
        [DataRow(60, true, true)]
        [DataRow(20, true, false)]
        [DataRow(20, false, false)]
        [DataRow(70, false, false)]
        [DataRow(59, false, true)]
        [DataRow(90, true, true)]
        public void HavePartyTest(int cigarsTest, bool isWeekend, bool expectedOutput)
        {
            CigarParty cigarParty = new CigarParty();
            bool actualOutput = cigarParty.HaveParty(cigarsTest, isWeekend);
            Assert.AreEqual(expectedOutput, actualOutput);

        }



    }
}
