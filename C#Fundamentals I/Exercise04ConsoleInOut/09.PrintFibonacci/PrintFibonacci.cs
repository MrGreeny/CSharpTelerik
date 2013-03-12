using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintFibonacci
{
    class PrintFibonacci
    {
        static void Main(string[] args)
        {
            uint first = 0;
            uint second = 1;
            uint temp;
            Console.Write("{0}, {1}, ", first, second);

            for (int i = 0 ; i < 100 ; i++)
            {
                Console.Write("{0}, " , first + second );
                temp = first;
                first = second;
                second = second + temp;
            }
        }
    }
}
