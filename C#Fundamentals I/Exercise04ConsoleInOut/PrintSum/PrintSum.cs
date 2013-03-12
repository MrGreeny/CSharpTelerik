using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintSum
{
    class PrintSum
    {
        static void Main(string[] args)
        {
            //Exercise 01
            int add1, add2, add3;
            Console.WriteLine("Please enter three numbers");
            add1 = Int32.Parse(Console.ReadLine());
            add2 = Int32.Parse(Console.ReadLine());
            add3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The {0} + {1} + {2} = {3}", add1, add2, add3, (add1 + add2 + add3));
        }
    }
}
