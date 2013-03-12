using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountDivisible
{
    class CountDivisible
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers\nFirst: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = first; i < second+1; i++)
            {
                if (i%5 ==0)
                {
                    ++count;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 5 between {1} and {2}",
                count, first, second);
        }
    }
}
