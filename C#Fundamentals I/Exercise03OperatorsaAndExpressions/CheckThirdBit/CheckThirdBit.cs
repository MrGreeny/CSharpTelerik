using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main(string[] args)
        {
            //Exercise 05
            Console.WriteLine("Enter number to check it's third bit");
            int number = int.Parse(Console.ReadLine());
            int mask = (1 << 3);
            int thirdBit = (mask & number) >> 3;
            Console.WriteLine("Third bit of {0} is {1}", number, thirdBit);
        }
    }
}
