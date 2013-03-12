using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapBits
{
    class SwapBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To exchange bits 3,4,5 with 24,25,26 enter a number:");
            uint num = uint.Parse(Console.ReadLine());
            int posP = 3;
            int posQ = 24;
            int k = 3;
            uint bitP;
            uint bitQ;

            if ((posP + k >= posQ) && (posQ + k >= 32))
            {
                Console.WriteLine("Invalid input! Try Again.");
            }

            for (int i = 0; i < 2 ; i++)
            {
                bitP = GetBit(num, posP +i);
                bitQ = GetBit(num, posQ +i);
                num = PlaceBit(num, posP + i, bitQ);
                num = PlaceBit(num, posQ + i, bitP);
            }
            Console.WriteLine("The new number is {0}:",num);
        }

        static uint GetBit(uint num, int pos )
        {
            return ((num & (1U << pos)) >> pos);
        }

        static uint PlaceBit(uint num, int position, uint bit)
        {
            uint mask;
            if (bit == 0)
            {
                mask = ~(1U << position);
                num = num & mask;
            }
            else
            {
                mask = 1U << position;
                num = num | mask;
            }
            return num;
        }
    }
}
