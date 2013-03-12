using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01InitializeArrayFactorFive
{
    class Ex01InitializeArrayFactorFive
    {
        static void Main(string[] args)
        {
            int[] factorFiveArray = new int[20];
            for (int i = 0; i < factorFiveArray.Length; i++)
            {
                factorFiveArray[i] = i * 5;
            }

            for (int i = 0; i < factorFiveArray.Length; i++)
            {
                Console.Write("{0} ",factorFiveArray[i]);
            }
        }
    }
}
