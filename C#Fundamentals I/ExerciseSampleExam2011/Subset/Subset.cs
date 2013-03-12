using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subset
{
    class Subset
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int top = (int) Math.Pow(2, (double)n);
            top -= 1;
            long sum;
            long[] arr = new long[n];
            int result = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }

            for (int i = 0; i < top; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int and = i & mask;
                    int bit = and >> j;
                    if (bit == 1)
                    {
                        sum += arr[j];
                    }
                }
                if (sum == s)
                {
                    result++;
                }
                
                
            }
            Console.WriteLine(result);


        }
    }
}
