using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{

    [TestClass()]
    public class AnimalGroupNameTests
    {
        [DataTestMethod]
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

            Assert.AreEqual(expectedOutput, actualOutput);





             /*string actualResult1 = animalGroupName.GetHerd("Rhino");
             string actualResult2 = animalGroupName.GetHerd("giRaFFe");
             string actualResult3 = animalGroupName.GetHerd("elephant");
             string actualResult4 = animalGroupName.GetHerd("lion");
             string actualResult5 = animalGroupName.GetHerd("crow");
             string actualResult6 = animalGroupName.GetHerd("pigeon");
             string actualResult7 = animalGroupName.GetHerd("flamingo");
             string actualResult8 = animalGroupName.GetHerd("deer");
             string actualResult9 = animalGroupName.GetHerd("Dog");
             string actualResult10 = animalGroupName.GetHerd("Crocodile");
             string actualResult11 = animalGroupName.GetHerd(null);
             string actualResult12 = animalGroupName.GetHerd("Yo whats up");
*/

            /*Assert.AreEqual("Crash", actualResult1);
            Assert.AreEqual("Tower", actualResult2);
            Assert.AreEqual("Herd", actualResult3);
            Assert.AreEqual("Pride", actualResult4);
            Assert.AreEqual("Murder", actualResult5);
            Assert.AreEqual("Kit", actualResult6);
            Assert.AreEqual("Pat", actualResult7);
            Assert.AreEqual("Herd", actualResult8);
            Assert.AreEqual("Pack", actualResult9);
            Assert.AreEqual("Float", actualResult10);
            Assert.AreEqual("unknown", actualResult11);
            Assert.AreEqual("unknown", actualResult12);*/

            // Do one for null, unknown (and this doesn't apply here, but the lower and upper bounds)

        }
    }
}
