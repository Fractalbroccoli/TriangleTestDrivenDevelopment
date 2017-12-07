// File        : Triangle.cs
// Author      : Ricardo Mohammed
// Project     : Test Driven Development - Software Quality A4
// Date        : December 6th, 2017
// Description : Contains the Triangle class. A Triangle consists of 
//               three angles, three sides, and may or may not be a right-angled triangle.
//               Triangle attributes may be calculated, e.g. measure of the third angle, 
//               given the measures of the other two angles.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace triangleTDD
{
    // Class       : Triangle
    // Description : This class represents a triangle. The angles and sides of
    //               a Triangle object can be discovered if known sides and angles
    //               are provided.
    //               Contains following functionality:
    //                  - Determine the third angle of a triangle given the other two angles.
    public class Triangle
    {
        public bool IsTriangleRight;    // Is this a right triangle?

        // Angle measure data members
        public double angle1Measure;
        public double angle2Measure;
        public double angle3Measure;


        // Side length data members
        public double side1Length;
        public double side2Length;
        public double side3Length;

        //=============================== Commit #1 ===============================

        // Method       : FindMissingAngle()
        // Parameters   : double angle1: The measure of the first angle.
        //                double angle2: The measure of the second angle.          
        // Returns      : double angle3: The measure of the third angle.
        // Description  : Finds the last angle in a triangle, given the measures
        //                of the other two angles.
        public double FindMissingAngle(double angle1, double angle2)
        {
            return 0;
        }
    }
}
