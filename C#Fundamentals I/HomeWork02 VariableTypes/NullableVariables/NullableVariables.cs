using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableVariables
{
    class NullableVariables
    {
        static void Main(string[] args)
        {
            //Exercise 13
            int? nullInt = null;
            double? nullDouble = null;
            nullInt += 10;
            nullDouble += 10.5;
            Console.WriteLine("nullIint + 10 = {0}\nnullDouble +10.5 ={1}", nullInt, nullDouble);
        }
    }
}
