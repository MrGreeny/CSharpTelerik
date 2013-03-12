using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex05SortStringArray
{
    class Ex05SortStringArray
    {
        static void Main(string[] args)
        {
            //The array to be sorted
            string[] strArr = { "ala", "bala", "m", "blahaa", "mr", "Petersson" };

            
            //Keeps the number of times ellements of the array were swapped
            int sortCount = 0;

            //Until no swaps have been made, the algorythm swaps two adjacent 
            //ellements of the array, where the second string was longer
            while (true)
            {
                string temp;
                //For every ellement of the array, the algorythm compares it with the next one
                for (int i = 0; i < strArr.Length-1; i++)
                {
                    if (strArr[i].Length > strArr[i+1].Length)
                    {
                        temp = strArr[i];
                        strArr[i] = strArr[i + 1];
                        strArr[i + 1] = temp;
                        sortCount++;
                    }
                }

                //If no swapping occured, then break exits the infinite loop
                if (sortCount == 0)
                {
                    break;
                }
                else
                {
                    sortCount = 0;
                }
            }

            Console.WriteLine("The sorted array looks like this:");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write("{0} ", strArr[i]);
            }
            Console.WriteLine();
        }
    }
}
