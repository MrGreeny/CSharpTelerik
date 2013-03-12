using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How manny numbers do you want to print?");
            int n = int.Parse(Console.ReadLine());
            while (n <= 1)
            {
                Console.WriteLine("Try Again");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
