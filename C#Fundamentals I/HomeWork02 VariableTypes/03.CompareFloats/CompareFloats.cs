using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 03
            float compareFirstShort = 5.3f;
            float compareSecondShort = 5.8f;
            Console.WriteLine("{0} == {1} = {2}", compareFirstShort, compareSecondShort, (compareFirstShort == compareSecondShort)); //False


            float compareFirstLong = 5.00000002f;
            float compareSecondLong = 5.00000009f;
            Console.WriteLine("{0} == {1} = {2}", compareFirstLong, compareSecondLong,(compareFirstLong == compareSecondLong)); //True
        }
    }
}
