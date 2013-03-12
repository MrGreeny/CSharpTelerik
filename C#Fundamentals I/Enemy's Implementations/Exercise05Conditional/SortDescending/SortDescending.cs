using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortDescending
{
    class SortDescending
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers\nFirst: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Second: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Third: ");
            double third = double.Parse(Console.ReadLine());
            double temp;

            if (first < second)
            {
                if (first < third)
                {
                }
                else if (third < first)
                {
                    temp = third;
                    third = first;
                    first = temp;
                }
            }
        }
    }
}
