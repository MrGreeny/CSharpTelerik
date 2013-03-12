using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueOfBthBit
{
    class ValueOfBthBit
    {
        static void Main(string[] args)
        {
            //Exercise 11
            Console.Write("Number i: ");
            int intI = int.Parse(Console.ReadLine());
            Console.Write("\nPosition b: ");
            int b = int.Parse(Console.ReadLine());
            intI = (intI >> b);
            int resultBit = intI % 2;
            Console.WriteLine("The desired bit is.... {0}\nBa Dum Tsss..",resultBit);
        }
    }
}
