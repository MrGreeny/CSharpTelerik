using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikLogo2
{
    class logo2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] arr = new string[(2 * n + 1), (2 * n + 1)];
            for (int i = 0; i < 2 * n + 1; i++)
            {
                for (int j = 0; j < 2 * n + 1; j++)
                {
                    arr[i,j] = ".";
                }
            }

            for (int i = 0; i < 2*n-1; i++)
            {
                
            }




            for (int i = 0; i < 2 * n + 1; i++)
            {
                for (int j = 0; j < 2 * n + 1; j++)
                {
                    Console.Write( arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
