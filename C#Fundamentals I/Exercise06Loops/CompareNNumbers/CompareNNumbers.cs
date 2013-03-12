using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareNNumbers
{
    class CompareNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numberw would you like to compare?");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            int counter = 0;
            int max = 0;
            int min = 0;
            int input;
            Console.WriteLine("Enter the numbers on an individual row");
            while (counter < n)
            {
                input = int.Parse(Console.ReadLine());
                if (counter == 0)
                {
                    min = input;
                    max = input;
                }
                
                if (input < min)
                {
                    min = input;
                }
                if (input > max)
                {
                    max = input;
                }
                counter++;
            }
            Console.WriteLine("Biggest number is {0}, smallest is {1}", max, min);
        }
    }
}
