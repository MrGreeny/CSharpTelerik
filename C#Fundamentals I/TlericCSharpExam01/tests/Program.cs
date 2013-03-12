using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {

            char first = char.Parse(Console.ReadLine());
            int firstNumber = ((int)first - 64);

            Console.WriteLine(firstNumber);
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
