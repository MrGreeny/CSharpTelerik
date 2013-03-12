using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBits
{
    class TestBits
    {
        static void Main(string[] args)
        {
            uint num = 57;
            int posP = 2;
            int posQ = 4;
            int k = 3;
            uint bitP;
            uint bitQ;
            uint mask;

            //uint maskP = 1U << posP;
            //uint maskQ = 1U << posQ;
            //uint numAndMaskP = num & maskP;
            //uint numAndMaskQ = num & maskQ;
            //bitP = numAndMaskP >> posP;
            //bitQ = numAndMaskQ >> posQ;

            bitP = (num & (1U << posP)) >> posP;
            bitQ = (num & (1U << posQ)) >> posQ;
            Console.WriteLine("P:{0}, Q:{1}\n", bitP, bitQ);

            //Console.WriteLine("Bit #{0}={1}\nBit #{2}={3} ", posP, bitP, posQ, bitQ);
            Console.WriteLine("{0}\n", num);

            if (bitP == 0)
            {
                mask = ~(1U << posQ);
                num = num & mask;
            }
            else
            {
                mask = 1U << posQ;
                num = num | mask;
            }

            if (bitQ == 0)
            {
                mask = ~(1U << posP);
                num = num & mask;
            }
            else
            {
                mask = 1U << posP;
                num = num | mask;
            }
            Console.WriteLine("{0}\n", num);

        }
    }
}
