using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolveEquation
{
    class SolveEquation
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the coeficients a, b, c, of the equation ax^2+bx+c=0 ");

            Console.Write("a= ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c= ");
            c = double.Parse(Console.ReadLine());

            double discr = (b * b) - (4 * a * c);

            if (discr > 0)
            {
                Console.WriteLine("x1 = {0:F3}, x2 = {1:F3}",
                    (-b + Math.Sqrt(discr)) / (2.0 * a),
                    (-b - Math.Sqrt(discr)) / (2.0 * a));
            }

            else if (discr == 0)
            {
                Console.WriteLine("x1 = x2 = {0:F3}", (-b) / (2.0 * a));
            }

            else if (discr < 0)
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
