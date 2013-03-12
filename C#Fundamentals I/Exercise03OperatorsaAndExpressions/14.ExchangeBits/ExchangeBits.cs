using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be transformed\nNumber:");
            uint num = uint.Parse(Console.ReadLine());

            Console.Write("Position p:");
            int posP = int.Parse(Console.ReadLine());

            Console.Write("Position q:");
            int posQ = int.Parse(Console.ReadLine());

            Console.Write("Range k:");
            int k = int.Parse(Console.ReadLine());

            uint bitP; //The bit at position p
            uint bitQ; //The bit at position q

            //Ranges can't overlap
            if ((posP + k >= posQ) && (posQ + k >= 32))
            {
                Console.WriteLine("Invalid input! Try Again.");
            }
            else
            {
                for (int i = 0; i < k - 1; i++)
                {
                    bitP = GetBit(num, posP + i);
                    bitQ = GetBit(num, posQ + i);
                    num = PlaceBit(num, posP + i, bitQ);
                    num = PlaceBit(num, posQ + i, bitP);
                }
                Console.WriteLine("The new nmber is {0}\nYou shapeshifter! ", num);
            }
        }

        //Returns the bit at position pos of the number num
        static uint GetBit(uint num, int pos )
        {
            return ((num & (1U << pos)) >> pos);
        }

        //returns a uint number, where bit is placed at the given position
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
