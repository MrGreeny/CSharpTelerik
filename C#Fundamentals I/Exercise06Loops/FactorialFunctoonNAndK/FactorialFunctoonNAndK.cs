using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorialFunctoonNAndK
{
    class FactorialFunctoonNAndK
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Enter N and K");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());
            if (n < 1 || k < 1 || n > k)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                double result = ((double) Factorial(n) * (double) Factorial(k)) / (double) Factorial(k-n);
                Console.WriteLine("{0}!*{1}!/({0}-{1})! = {2} ", n, k, result);
            }
            
        }
        static ulong Factorial(ulong n)
        {
            if (n == 0 || n == 1)
            {
                //By definition 0! and 1! are equal to 1
                return 1;
            }
            else
            {
                ulong sum = 1;
                for (ulong i = 1; i < n + 1; i++)
                {
                    sum = sum * i;
                }
                return sum;
            }            
        }
    }
}
