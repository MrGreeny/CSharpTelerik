using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex05MaxIncerasingSequenceInArray
{
    class Ex05MaxIncerasingSequenceInArray
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 5, 7, 3, 3, 6, 6, 6, 6, 2, 3, 5, 6, 8, 10, 5, 5, 5, 7, 8, 2 };
            int maxSequence = 1;
            int lastOfSequence = 0;
            int runningSequence = 1;
            //bool stillInThisSequence = true;


            for (int i = 1; i < testArray.Length; i++)
            {
                if (testArray[i] > testArray[i - 1])
                {
                    //runnungSequence keeps the most recent sequence of equal numbers
                    runningSequence++;
                }
                else
                {
                    //if the numbers are different the running sequence gets
                    //to its default value - 1
                    runningSequence = 1;
                }

                //If the running sequense is bigger than the current maximal
                if (runningSequence >= maxSequence)
                {
                    maxSequence = runningSequence;
                    //Keeps the last element of the sequence of equal numbers
                    lastOfSequence = i;
                }
            }

            if (maxSequence == 1)
            {
                Console.WriteLine("No elements of the array appear more than once");
            }
            else
            {
                //Prints the longest seqence
                for (int i = 0; i < maxSequence; i++)
                {
                    Console.Write("{0} ", testArray[lastOfSequence - maxSequence + i +1]);
                }
            }
        }
    }
}
