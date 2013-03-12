using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 01
            //int add1, add2, add3;
            //Console.WriteLine("Please enter three numbers");
            //add1 = Int32.Parse(Console.ReadLine());
            //add2 = Int32.Parse(Console.ReadLine());
            //add3 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("The {0} + {1} + {2} = {3}", add1, add2, add3, (add1+add2+add3));


            //Ex 02
            Console.WriteLine("Please enter the radius of the circle");
            double radius = Double.Parse(Console.ReadLine());
            double pi = 3.14159265359;
            Console.WriteLine("The circle with radius {0:F3} has perimeter {1:F3} and area {2:F3}",radius, 2*pi*radius, (pi*radius*radius) );
        }
    }
}
