﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartesianCoordSystem
{
    class CartesianCoordSystem
    {
        static void Main(string[] args)
        {
                float x = float.Parse(Console.ReadLine());
                float y = float.Parse(Console.ReadLine());


            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if (x == 0)
            {
                Console.WriteLine("5");
            }
            else if (y == 0)
            {
                Console.WriteLine("6");
            }
        }
    }
}
