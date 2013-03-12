using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsIntPrime
{
    class IsIntPrime
    {
        static void Main(string[] args)
        {
            //Exercise 07
            Console.WriteLine("Enter number to find out if it's prime");
            int testPrime = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (testPrime <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else if (testPrime == 1 | testPrime == 2)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                for (int i = 2; i < testPrime / 2; i++)
                {
                    if (testPrime % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime");
            }
        }
    }
}
