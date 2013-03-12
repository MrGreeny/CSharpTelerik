using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main(string[] args)
        {
            //Exercise 04
            Console.WriteLine("Enter number to check if third digit is seven");
            int checkForSeven = int.Parse(Console.ReadLine());
            checkForSeven /= 100;
            Console.WriteLine(((checkForSeven % 10) == 7) ? "Third digit is seven" : "Third digit is not seven");

        }
    }
}
