using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAsciiTable
{
    class PrintAsciiTable
    {
        static void Main(string[] args)
        {
            //Exercise 12 
            int counter;
            for (counter = 0; counter < 128; counter++)
            {
                char asciiChar = (char)counter;
                string asciiStr = asciiChar.ToString();
                Console.Write("{0} ", asciiStr);
            }
        }
    }
}
