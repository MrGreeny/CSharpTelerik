using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CastingChars
{
    class CastingChars
    {
        static void Main(string[] args)
        {
            //Exercise 05
            char unicodeCharCast = (char)0x48;
            char unicodeChar = '\u0048';
            Console.WriteLine(unicodeChar);  //H
        }
    }
}
