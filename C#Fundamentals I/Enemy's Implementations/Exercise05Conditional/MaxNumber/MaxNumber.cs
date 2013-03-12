using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five numbers\nFirst: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Second: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Third: ");
            double third = double.Parse(Console.ReadLine());
            Console.Write("Fourth: ");
            double fourth = double.Parse(Console.ReadLine());
            Console.Write("Fifth: ");
            double fifth = double.Parse(Console.ReadLine());
            double result = Math.Max(first,Math.Max(second,Math.Max(third,Math.Max(fourth,fifth))));
            Console.WriteLine("The biggest number is {0}", result);


        }
    }
}
