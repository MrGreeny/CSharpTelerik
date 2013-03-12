using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsPointIncircle
{
    class IsPointInCircle
    {
        static void Main(string[] args)
        {
            //Exercise 06
            int r = 5; //radius
            Console.WriteLine("Here you can check if a point is within a circle with radius {0}", r);
            Console.Write("Enter the coordinates of the point\nX: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("The point is ");
            Console.WriteLine( ((x * x) + (y * y) <= (r*r))? "inside." : "outside.");
        }
    }
}
