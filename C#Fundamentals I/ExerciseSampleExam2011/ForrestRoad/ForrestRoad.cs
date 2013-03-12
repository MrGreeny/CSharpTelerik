using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForrestRoad
{
    class ForrestRoad
    {
        static void Main(string[] args)
        {
            int forest = int.Parse(Console.ReadLine());
            int rows = 2 * forest - 1;
            int count = 0;
            int position = 0;
            bool change = true;

            while (count < rows)
            {
                    for (int i = 0; i < forest; i++)
                    {
                        if (position == i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    Console.Write("\n");

                    if (position == forest - 1)
                    {
                        change = false;
                    }

                    if (change)
                    {
                        position++;
                    }
                    else
                    {
                        position--;
                    } 
                count++;
            }

        }
    }
}
