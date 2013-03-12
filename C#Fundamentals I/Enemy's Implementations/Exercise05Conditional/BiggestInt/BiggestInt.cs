using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggestInt
{
    class BiggestInt
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers\nFirst: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Third: ");
            int third = int.Parse(Console.ReadLine());

            
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("{0} is the biggest", first);
                }
                else if (third < first)
                {
                    Console.WriteLine("{0} is the biggest", third);
                }
            }
            else if (second > first)
            {
                if (second > third)
                {
                    Console.WriteLine("{0} is the biggest", second);
                }
                else
                {
                    Console.WriteLine("{0} is the biggest", third);
                }
            }
            else if (first == second)
            {
                if (first > third)
                {
                    Console.WriteLine("{0}= {1} is the biggest", first, second);
                }
                else if (third > first)
                {
                    Console.WriteLine("{0} is the biggest", third);
                }
                else
                {
                    Console.WriteLine("Numbers are all equal, BOOYAH!");
                }

            }

        }
    }
}
