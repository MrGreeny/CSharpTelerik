using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintPerimeer
{
    class PrintPerimeter
    {
        static void Main(string[] args)
        {
            //Ex 02
            Console.WriteLine("Please enter the radius of the circle");
            double radius = Double.Parse(Console.ReadLine());
            double pi = 3.14159265359;
            Console.WriteLine("The circle with radius {0:F3} has perimeter {1:F3} and area {2:F3}"
                , radius, 2 * pi * radius, (pi * radius * radius));
        
        }
    }
}
