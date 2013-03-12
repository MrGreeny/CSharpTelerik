using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex10FindPreDefinedSequence
{
    class Ex10FindPreDefinedSequence
    {
        static void Main(string[] args)
        {
            int[] preDefinedSeq = { 1, 2, 3 };
            int[] arrToFindSeq = { 1, 3, 8, 66, -1, 51, 8, 8, 1, 3, 192, 8, 99, 0, 2, 3 };
            int numOfMatches = 0;
            bool exit = false;

            if (preDefinedSeq.Length > arrToFindSeq.Length)
            {
                exit = true;
            }

            for (int i = 0; i < arrToFindSeq.Length; i++)
            {
                //If we reached the end of the array, exit becomes true
                if (exit)
                {
                    break; 
                }

                //for every number in the big array we run thru the small array
                //and look for a match
                for (int j = 0; j < preDefinedSeq.Length; j++)
                {
                    //If we still haven't reached the end of the array
                    if (i+j < arrToFindSeq.Length)
                    {
                        if (preDefinedSeq[j] == arrToFindSeq[i + j])
                        {
                            numOfMatches++;
                        }  
                    }
                    else
                    {
                        exit = true;
                        break;
                    }

                }
                //if we have matches and they are equal to the length of the
                //small array
                if (numOfMatches == preDefinedSeq.Length)
                {
                    Console.WriteLine("Bingo!");
                    break;
                }
                else
                {
                    numOfMatches = 0;
                }
            }
            //exit is true if we found no matches or the size of the small array is bigger
            if (exit)
            {
                Console.WriteLine("Try again");
            }
           

        }
    }
}
