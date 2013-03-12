using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02CompareArrays
{
    class Ex02CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the arrays you want to compare.");
            int size = int.Parse(Console.ReadLine());
            
            //Due to no specification of the type of the array it's int

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];

            //Reading the elements of the arrays from the console.
            Console.WriteLine("Enter the values of the first array on separate lines");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the values of the second array on separate lines");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            bool arraysAreTheSame = true;

            //Comparing the arrays
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    arraysAreTheSame = false;
                    break;
                }
            }

            if (arraysAreTheSame)
            {
                Console.WriteLine("The entered arrays have the same values.");
            }
            else
            {
                Console.WriteLine("The values of the arrays are different.");
            }

        }
    }
}
