using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNonDivisibleNumbersOneToN
{
    class PrintNonDivisibleNumbersOneToN
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
                    if (counter % 3 != 0 || counter % 7 != 0)
                    {
                        Console.WriteLine(counter);
                    }
                    counter++;
                }
            }
        }
    }
}
