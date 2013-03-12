using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex06FindMaximalSum
{
    class Ex06FindMaximalSum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter N and K on separate rows");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elemrnts of the array on separate rows");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Basically the array is sorted and then the sum of the last k ellements is taken
            Array.Sort(arr);
            int sum = 0;

            Console.WriteLine("These are the elements with the max sum:");
            for (int i = arr.Length - k; i < arr.Length; i++)
            {
                Console.Write(" {0},",arr[i]);
                sum += arr[i];
            }

            Console.WriteLine("and their sum is {0}", sum);
        }
    }
}
