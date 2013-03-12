using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            ////Thanks for the hint.

            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int temp;

            int count = 0;

            while (i <= n)
            {
                temp = i;
                //Because numbers like 25 have multiple factors of five
                while (temp % 5 == 0)
                {
                    ++count;
                    temp /= 5;
                }
                ++i;
            }
            Console.WriteLine("There are {0} zeroes trailing {1}!", count, n);
           

        
        }
    }
}
