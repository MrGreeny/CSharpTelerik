using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex07SelectionSort
{
    class Ex07SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 1, 4, 1, 8, 66, -1, 51, 45, 82, 192, 99, 0, 3, 1 };
            int temp;
            int indexOfSmallest;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                //Determinig the index of the smallest ellement
                indexOfSmallest = FindSmallest(arrayToSort, i);

                //Swapping ellements
                temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[indexOfSmallest];
                arrayToSort[indexOfSmallest] = temp;
            }

            //Printing the array
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write("{0} ", arrayToSort[i]);
            }
        }

        //Finds the index of the smallest number in one array
        //The method takes one more variable - indexToStart
        //Before this index, all the ellements are already sorted
        //and smaller than the next ones, so the methood starts at this index
        static int FindSmallest(int[] arr, int indexToStart)
        {
            //Just a initial value. Can't be arr[0]
            int smallest = arr[indexToStart];
            //If the function returns -1, than we have an error
            int index = -1;

            for (int i = indexToStart; i < arr.Length; i++)
            {
                //Compares the ellements and keeps the index of the smallest
                if (arr[i] <= smallest)
                {
                    smallest = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
