using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            //Exercise 01
            Console.Write("Enter a number to check if it's odd or even\nNumber:");
            int checkOddEven = int.Parse(Console.ReadLine());
            Console.WriteLine((checkOddEven % 2 == 0) ? "It's even" : "It's Odd");
         }

    }
}
