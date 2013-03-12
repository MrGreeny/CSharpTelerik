using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.AddNNumbes
{
    class AddNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to add?");
            int n = int.Parse(Console.ReadLine());
            while( n <= 0 )
            {
                Console.WriteLine("Try again.");
                n = int.Parse(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0}= ", i+1);
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The summ of all {0} digits is {1}", n, sum);
        }
    }
}
