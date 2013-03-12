using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Catalan number would you like to see?");
            ulong n = ulong.Parse(Console.ReadLine());
            if (n<=0)
            {
                Console.WriteLine("Invalid Input. N must be >0");
            }
            double top = (double)Factorial(2 * n);
            double bottom = (double)Factorial(n + 1) * (double)Factorial(n);
            Console.WriteLine("The {0}-th catalan number is {1}",n,top/bottom);

        }

        //static double Choose(ulong n, ulong k)
        //{
        //    double top = (double)Factorial(n);
        //    double bottom = (double)Factorial(k) * (double)Factorial(n - k);
        //    if (n >= k)
        //    {
        //        return top / bottom;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

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
