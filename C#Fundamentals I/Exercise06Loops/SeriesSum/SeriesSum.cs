using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesSum
{
    class SeriesSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N and X on different rows");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int counter = 1;
            double sum = 1;
            while (counter < n+1)
            {
                sum += (double)Factorial(counter) / (double) Power(x, counter);
                counter++;                
            }
            Console.WriteLine("The sum of the series is {0}",sum);

        }
        static int Power(int number, int power)
        {
            int counter = 2;
            if (power == 0)
            {
                return 1;
            }
            else if (power == 1)
            {
                return number;
            }
            else if (power > 1)
            {
                while (counter < power)
                {
                    number *= number;
                    counter++;
                }
            }
            else
            {
                return -1;
            }
            return number;
        }
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                //By definition 0! and 1! are equal to 1
                return 1;
            }
            else
            {
                int sum = 1;
                for (int i = 1; i < n + 1; i++)
                {
                    sum = sum * i;
                }
                return sum;
            }
        }
    }
}
