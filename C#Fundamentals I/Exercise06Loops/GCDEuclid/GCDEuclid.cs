using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCDEuclid
{
    class GCDEuclid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to get their GCD");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("GCD of {0} and {1} is {2}",a, b, Euclid(a,b));
        }

        static int Euclid(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Euclid(b, a % b);
            }
        }
    }
}
