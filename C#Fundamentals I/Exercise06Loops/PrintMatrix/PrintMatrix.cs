using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            int num = 0 ;
            if (n > 20)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {

                for (int i = 0; i < n; i++)
                {
                    num += 1;
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j + 1 < 10)
                        {
                            Console.Write("{0}  ", i + j + 1);
                        }
                        else
                        {
                            Console.Write("{0} ", i + j + 1);
                        }
                        
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
