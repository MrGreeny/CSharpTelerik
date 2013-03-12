using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex08FindMaxSumSequence
{
    class Ex08FindMaxSumSequence
    {
        static void Main(string[] args)
        {
            //k is the number of elements of the array we want to add
            int k = 3;
            
            int[] arrToFindSum = { 1, 4, 1, 8, 66, -1, 51, 45, 82, 192, 99, 0, 3, 1 };
            int maxSum = arrToFindSum[0];
            int maxSumIndex = 0;
            int runningSum = 0;

            for (int i = k-1; i < arrToFindSum.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    runningSum += arrToFindSum[i - j];
                }
                if (runningSum > maxSum)
                {
                    maxSum = runningSum;
                    maxSumIndex = i;
                }
                else
                {
                    runningSum = 0;
                } 
            }
            Console.WriteLine(maxSum);
            Console.WriteLine(maxSumIndex);

            //for (int i = maxSumIndex; i < k; i++)
            //{
                
            //}


        }
    }
}
