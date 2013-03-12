using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04BinSearch
{
    class Ex04BinSearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("How long is the aray you want to enter?");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the ellements of the array on a different lines.");

            for (int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            //Sorting the array, because of the BinarySearch
            Array.Sort(arr);

            //If the value is not found, the BinarySearch returns the index of the next elemenr
            //with negative sign and +1
            int result = Array.BinarySearch(arr, k );

            if (result >= 0)
            {
                Console.WriteLine("The value K={0} was found at position {1} in the array", k, result);
            }
            else
            {
                Console.WriteLine("The value K={0} was not found in the array."
                    +" The largest ellement of the array less or equal than K={0} is {1}", k, arr[-result-1]);
                  
            }
        }
    }
}
