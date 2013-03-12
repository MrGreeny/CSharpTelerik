using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex11BinarySearch
{
    class Ex11BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arrToFindKey = { 0,1, 12, 3, 4, 18, 5, 7, 8, 6, 9,8 };
            Array.Sort(arrToFindKey);
            // key is the value, we want to find in the array
            int key = 11;
            int leftIndex = 0;
            int rightIndex = arrToFindKey.Length;
            int middleIndex = (leftIndex + rightIndex) / 2;

            while (arrToFindKey[middleIndex] != key)
            {
                if (key > arrToFindKey[middleIndex])
                {
                    leftIndex = middleIndex;
                    middleIndex = (leftIndex + rightIndex) / 2;
                }
                else if (key < arrToFindKey[middleIndex])
                {
                    rightIndex = middleIndex;
                    middleIndex = (leftIndex + rightIndex) / 2;

                }
                else
                {
                    Console.WriteLine("error");
                    break;
                }
            }
            Console.WriteLine("The index of the key {0} is {1}",key, middleIndex);

           
            
        }
    }
}
