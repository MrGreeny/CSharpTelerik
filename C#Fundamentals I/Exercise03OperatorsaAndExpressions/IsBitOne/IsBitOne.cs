using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBitOne
{
    class IsBitOne
    {
        static void Main(string[] args)
        {
            //Exercise 10
            Console.Write("Check if bit is one.\nNumber:");
            int number = int.Parse(Console.ReadLine());

            Console.Write("\nPosition:");
            int p = int.Parse(Console.ReadLine());

            int mask = (1 << p);
            bool result = ((mask & number) == 0 ? false : true);
            Console.WriteLine(result);
            
        }
    }
}
