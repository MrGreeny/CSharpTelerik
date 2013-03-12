using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            int count = 0;
            uint[] arr = new uint[n];

            while (count < n)
            {
                arr[count] = uint.Parse(Console.ReadLine());
                count++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (b == 0)
                {
                    Console.WriteLine(FindZeros(arr[i]));
                }
                else
                {
                    uint p = arr[i];
                    uint byteCount = 0;
                    while (p>0)
                    {
                        byteCount++;
                        p = p >> 1;
                    }
                    Console.WriteLine(byteCount - FindZeros(arr[i]));
                }
            }
        }
        static uint FindZeros(uint n)
        {
            uint mask;
            uint zeros = 0;
            while (n > 0)
            {
                mask = 1;
                if ((mask & n) == 0)
                {
                    zeros++;
                }

                n = n >> 1;
            }
            return zeros ;
        }
    }
}
