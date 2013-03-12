using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateSeries
{
    class CalculateSeries
    {
        static void Main(string[] args)
        {
            double sum = 1;
            double difference;
            double temp;
            double n = 2;

            do
            {
                temp = sum;
                if (n % 2 == 0)
                {
                    sum += (1.0 / n);

                }
                else
                {
                    sum -= (1.0 / n);
                }

                n += 1.0;
                difference = Math.Abs(temp - sum);

            } while (difference > 0.001);

            Console.WriteLine("The sum of the series is: {0}",sum);
        }
    }
}
