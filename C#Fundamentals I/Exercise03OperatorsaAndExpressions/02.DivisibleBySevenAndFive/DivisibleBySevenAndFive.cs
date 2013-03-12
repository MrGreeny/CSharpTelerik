using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisibleBySevenAndFive
{
    class DivisibleBySevenAndFive
    {
        static void Main(string[] args)
        {
            //Exercise 02
            Console.WriteLine("Enter number to test for divisibility by 7 and 5");
            int divSevenFive = int.Parse(Console.ReadLine());
            bool divides;
            divides = ((divSevenFive % 5 == 0 && divSevenFive % 7 == 0) ? divides = true : divides = false);
            Console.WriteLine(divides);
        }
    }
}
