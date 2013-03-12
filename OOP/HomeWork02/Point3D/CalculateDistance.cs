using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    public static class CalculateDistance
    {
        //Exercise 3
        public static double Calculate(Point3D a, Point3D b)
        {
            double result;
            //Assigns the euclidean distance to the variable result
            result = ((a.X - b.X) * (a.X - b.X)) + ((a.Y - b.Y) * (a.Y - b.Y)) + ((a.Z - b.Z) * (a.Z - b.Z));
            result = Math.Sqrt(result);
            return result;
        }
    }
}
