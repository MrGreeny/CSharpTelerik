using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissCat2011
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int voters = int.Parse(Console.ReadLine());
            int count = 0;
            int[] votes = {-1,0,0,0,0,0,0,0,0,0,0}; //0 - 10
            int vote;
            int winner = 0;

            while (count < voters)
            {
                vote = int.Parse(Console.ReadLine());
                votes[vote]++;
                count++;
            }

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] > votes[winner])
                {
                    winner = i;
                }
            }
            Console.WriteLine(winner);

        }
    }
}
