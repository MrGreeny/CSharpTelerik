using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcellColumns
{
    class ExcellColumns
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int count = 0;
            char[] arr = new char[length];
            ulong sum = 0;
            while (count < length)
            {
                arr[count] = char.Parse(Console.ReadLine());
                count++;
            }


            int power = arr.Length -1;

            for (int i = 0; i < arr.Length; i++)
            {

                sum += (ulong)( ((ulong)arr[i] - 64) * (ulong)Math.Pow(26,power ));
                power--;
            }
            Console.WriteLine(sum);
        }

        static ulong Power(int num, int power)
        {
            ulong result = (ulong)num;
            ulong number = (ulong)num;

            for (int i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;

        }

    }

}
