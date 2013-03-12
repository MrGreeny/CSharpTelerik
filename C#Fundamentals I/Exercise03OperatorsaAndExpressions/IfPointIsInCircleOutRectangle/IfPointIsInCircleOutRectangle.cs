using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfPointIsInCircleOutRectangle
{
    class IfPointIsInCircleOutRectangle
    {
        static void Main(string[] args)
        {
            //Exercise 09
            Console.WriteLine
                (   "Enter the coordinates of a point to check if it's" + 
                    "in circle K and outside of rectangle R");

            Console.Write("X: ");
            double ptX = double.Parse(Console.ReadLine());

            Console.Write("\nY: ");
            double ptY = double.Parse(Console.ReadLine());

            bool belongsToK = ((((ptX - 1) * (ptX - 1)) + ((ptY - 1) * (ptY - 1))) <= 9);
            bool belongsToR = ((ptX >= -1) && (ptX <= 5) && (ptY >= -1) && (ptY <= 1));
            Console.WriteLine(belongsToK && belongsToR ? 
                "Belongs to the givenarea." : "Doesn't belong to given area." );

        }
    }
}
