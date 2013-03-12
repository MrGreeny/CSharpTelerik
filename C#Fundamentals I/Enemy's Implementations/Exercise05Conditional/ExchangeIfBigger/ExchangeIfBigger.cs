using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeIfBigger
{
    class ExchangeIfBigger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers\nFirst: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            int temp;

            if (first > second)
            {
                temp = first;
                first = second;
                second = temp;
                Console.WriteLine("Exchange complete First: {0}, Second:{1}", first, second);
            }
            else
            {
                Console.WriteLine("No exchange took part First: {0}, Second: {1}", first, second);
            }

        }
    }
}
