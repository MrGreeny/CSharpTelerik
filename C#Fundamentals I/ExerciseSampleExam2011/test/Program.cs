using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 2147483648;
            uint b = 0;
            uint mask;
            uint zeros = 0;
            
            if (b==0)
            {
                while (n > 0)
                {
                    //Console.WriteLine(n);
                    mask = 1;
                    if ((mask & n) == 0)
                    {
                        zeros++;
                    }

                    n = n >> 1;
                }
                Console.WriteLine(zeros);
                
            }
     
        }
    }
}
