using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers\nFirst: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            int result = Math.Max(first, second);
            Console.WriteLine("{0} is the greater of the numbers {1} and {2}", result, first, second);
        }
    }
}
