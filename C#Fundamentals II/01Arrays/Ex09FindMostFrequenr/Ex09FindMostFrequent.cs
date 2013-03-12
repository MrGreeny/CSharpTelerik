using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex09FindMostFrequenr
{
    class Ex09FindMostFrequent
    {
        static void Main(string[] args)
        {
            int[] arrToFindFrequent = { 1, 4, 1, 8, 66, -1, 51,8,8,8, 45, 82, 192,8, 99, 0, 3, 1 };
            //Sorting the array, so the equal numbers are one after another
            Array.Sort(arrToFindFrequent);
            int matches = 1;
            bool keepOnGoing = true; ;
            int lastIndex = 0;
            int tempMatch = 1;

            //starting from the second element arrToFindFrequent[1]
            //because arrToFindFrequent[i-1] is used
            for (int i = 1; i < arrToFindFrequent.Length; i++)
            {
                //if two adjacent numbers are equal we keep the index of the last,
                //the number of matches, and a bool variable, so we know
                //when to increment the matches and change the value of the index
                if (arrToFindFrequent[i] == arrToFindFrequent[i-1] )
                {
                    if (keepOnGoing)
                    {
                        matches++;
                        lastIndex = i;
                    }
                    keepOnGoing = true;
                    tempMatch = matches;

                }
                else
                {
                    keepOnGoing = false;
                    matches = 1;
                }
                
            }

            Console.WriteLine("The most frequent number is {0}, and it's found {1} times", arrToFindFrequent[lastIndex], tempMatch);
        }

    }
}
