using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass()]
    public class MaxEnd3Tests
    {
        /* [DataTestMethod]
         [DataRow(new int[] { 1, 2, 3 }, new int[] {3, 3, 3})]
         [DataRow(new int[] {11, 5, 9 }, new int[] {11, 11, 11})]
         [DataRow(new int[] { 2, 11, 3 }, new int[] {3, 3, 3})]
         [DataRow(new int[] { 1, 2, 3 }, new int[] {3, 3, 3})]

         public void MakeArrayTest(int[] nums,int[] expectedOutput)
         {
             MaxEnd3 maxEnd3Nick = new MaxEnd3();

             int[] actualOutput = maxEnd3Nick.MakeArray(nums);

             Assert.AreEqual(expectedOutput, actualOutput);

         }*/

        [DataTestMethod()]
        [DataRow(1, 2, 3, 3, 3, 3)]
        [DataRow(11, 5, 9, 11, 11, 11)]
        [DataRow(2, 11, 3, 3, 3, 3)]

        public void MakeArrayTest(int a, int b, int c, int d, int e, int f)
        {
            MaxEnd3 maxEnd3Nick = new MaxEnd3();

            int[] inputArray = new int[] { a, b, c };

            int[] expectedOutput = new int[] { d, e, f };

            int[] actualOutput = maxEnd3Nick.MakeArray(inputArray);

            Assert.AreEqual(expectedOutput[0], actualOutput[0]);
            Assert.AreEqual(expectedOutput[1], actualOutput[1]);
            Assert.AreEqual(expectedOutput[2], actualOutput[2]);


        }


    }
}
