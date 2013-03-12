using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            //Exercise 03
            Console.Write("Enter rectangle sides \nWidth: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double area = 0;
            if (width <= 0 | height <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            area = (width * height);
            Console.WriteLine
                ("The area of a rectangle with sides {0} and {1} is {2}",width,height, area);
        }
    }
}
