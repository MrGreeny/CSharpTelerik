using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            int n = int.Parse(str);

            if (n %10 != 6)
            {
                ++n;
            }
            else
            {
                int count = str.Length;
                bool six = true;

                while (six)
                {
 
                    int digit =  int.Parse(str[count - 1].ToString());
                    //Console.WriteLine(digit);
                    if (digit == 6)
                    {
                        Increment(int.Parse(str[count - 1].ToString()));
                        six = true;

                    }
                    else
                    {
                        six = false;
                    }
                    count--;
                }

            }
            //Console.WriteLine(n);

        }
        static int Increment(int n)
        {
            if (n == 6)
            {
                n = 0;
            }
            else
            {
                n++;
            }
            return n;
        }
    }
}
