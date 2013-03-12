using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            uint first = 0;
            uint second = 1;
            uint temp;
            uint sum = 1;
            Console.WriteLine("How many fibonacci numbers would you like to calculate she sum of?");
            int n = int.Parse(Console.ReadLine());
            if(n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            if (n == 1)
            {
                sum = 0;
            }

            for (int i = 0; i < n-1; i++)
            {
                sum += (first + second); 
                //Console.Write("{0}, ", first + second);
                temp = first;
                first = second;
                second = second + temp;
            }
            Console.WriteLine("The sum of the first {0} fibonacci numbers is {1}", n, sum);
        }
    }
}
