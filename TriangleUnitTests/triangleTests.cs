// File        : TriangleTests.cs
// Author      : Ricardo Mohammed
// Project     : Test Driven Development - Software Quality A4
// Date        : December 6th, 2017
// Description : This is the test class for the Triangle class.
//               It uses the built-in .NET unit test feature.



using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangleTDD;


namespace TriangleUnitTests
{
    // Class       : TriangleTests
    // Description : This is the test class for the Triangle module.
    //               It contains unit tests that test the attributes of a triangle.
    //               Tests the following functionality:
    //                  - Determine the third angle of a triangle given the other two angles.
    [TestClass]
    public class TriangleTests
    {
        // Commit 1

        // Test Method: TriangleValidAngles()
        // Description: Tests the FindMissingAngle() method, which determines the third
        //              angle of a triangle given the measures of the other two angles.
        [TestMethod]
        public void TriangleValidAngles()
        {
            // Arrange
            double angle1 = 30.1;
            double angle2 = 59.9;
            double expected = 90;


            Triangle triangle = new Triangle();


            // Act
            triangle.FindMissingAngle(angle1, angle2);
           
            double actual = triangle.angle3Measure;     

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "According to the Ancient Greeks, the third angle calculation was incorrect!");
        }
    }
}
