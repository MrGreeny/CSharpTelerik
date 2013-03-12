using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeBitValue
{
    class ChangeBitValue
    {
        static void Main(string[] args)
        {
            //Exercise 12
            int mask;
            Console.Write(
                "Stop! Who would cross the bridge of death must answer me these questions three.\nNumber n: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("\nPosition p: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("\nValue v: ");
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                mask = ~(1 << position);
                number = number & mask;
            }
            else
            {
                mask = 1 << position;
                number = number | mask;
            }

            Console.WriteLine("Off you go: {0}", number);
        }
    }
}
