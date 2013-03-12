using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikLogo
{
    class Logo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2*n+1; i++)
            {
                for (int j = 0; j < 2*n+1; j++)
                {
                   
                        //Rombcheto
                    if ( i >= n-1)// ako sme pod n-1 via red
                    {
                        if (i == n-1 && j == n)//purva tochka
                        {
                            Console.Write("*");
                        }
                        else if (i == 2*n && j == n)//posledna tochka
                        {
                            Console.Write("*");
                        }

                        else if ( false )//rombche //TODO
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }

                    }
                    else//ushichkite
                    {
                        if (i == 0 && (j == n / 2 || j == ((2 * n) - (n/2))))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
