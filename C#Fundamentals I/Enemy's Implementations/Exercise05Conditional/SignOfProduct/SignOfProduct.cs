using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignOfProduct
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers\nFirst: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Second: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Third: ");
            double third = double.Parse(Console.ReadLine());

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("Zero has no sign");
            }
            else if (first > 0)
            {
                if (second < 0 ^ third < 0)
                {
                    Console.WriteLine("Sign is -");
                }
                else
                {
                    Console.WriteLine("Sign is +");
                }
            }
            else if (first < 0)
            {
                if (second < 0 ^ third < 0)
                {
                    Console.WriteLine("Sign is +");
                }
                else
                {
                    Console.WriteLine("Sign is -");
                }
            }
        
        }
    }
}
