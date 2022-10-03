using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()



        /*public string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }*/

        [TestMethod()]
        public void MakeAbbaTest()
        {
            StringExercises stringExercises = new StringExercises();

            string actualResult = stringExercises.MakeAbba("Hi", "Bye");

            Assert.AreEqual("HiByeByeHi", actualResult);

        }

    }
}