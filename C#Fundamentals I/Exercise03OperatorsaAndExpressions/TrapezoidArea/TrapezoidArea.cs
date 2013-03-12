using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            //Exercise 08
            /// The sides and the height DO NOT define a trapezoid
            /// I'm assuming, the BASES are given
            Console.Write("To calculate the area of a trapezoid enter\n Base a: ");
            double trpzBaseA = int.Parse(Console.ReadLine());

            Console.Write("Base b: ");
            double trpzBaseB = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double trpzHeight = int.Parse(Console.ReadLine());

            if (trpzBaseA <= 0 | trpzBaseB <= 0 | trpzHeight <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                double trpzArea = 0;
                trpzArea = ((trpzBaseA + trpzBaseB) / 2) * trpzHeight;
                Console.WriteLine("The area of the trapezoid is {0}", trpzArea);
            }
        }
    }
}
