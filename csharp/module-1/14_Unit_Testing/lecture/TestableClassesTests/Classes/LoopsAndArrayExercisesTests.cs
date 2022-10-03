﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object


        [TestMethod]
        public void MiddleWayTest ()
        {
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();

            // Arrange
            
            int[] firstInput = { 1, 2, 23 };
            int[] secondInput = { 4, 5, 6 };

            //Act

            int[] actualResult = loopsAndArrayExercises.MiddleWay(firstInput, secondInput);

            //Assert

            int[] expectedResult = { 2, 5 };
            CollectionAssert.AreEqual(expectedResult, actualResult);
            

        }
    }
}