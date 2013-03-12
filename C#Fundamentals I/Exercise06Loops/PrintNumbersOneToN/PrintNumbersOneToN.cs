using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNumbersOneToN
{
    class PrintNumbersOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbeer N:");
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                while (counter <= n)
                {
                    Console.WriteLine(counter);
                    counter++;
                }
            }
        }
    }
}
