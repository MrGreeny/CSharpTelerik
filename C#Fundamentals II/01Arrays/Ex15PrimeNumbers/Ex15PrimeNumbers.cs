using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex15PrimeNumbers
{
    class Ex15PrimeNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10000001];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                if (i == arr.Length -1 )
                {
                    Console.WriteLine("Writing the numbers in the array complete.");
                }
            }
            int p = 2;
            bool stillNotReachedEnd = true;
            while (stillNotReachedEnd)
            {
                for (int i = p+1; i < arr.Length; i++)
                {
                    if ((arr[i] != -1))
                    {
                        if (arr[i] % p == 0)
                        {
                            arr[i] = -1;
                        }    
                    }
                }

                for (int i = p+1; i < arr.Length; i++)
                {
                    if (arr[i] != -1)
                    {
                        p = arr[i];
                        Console.WriteLine("Removing multiples of {0}...", p);
                        break;
                    }
                    else if (i == arr.Length -1)
                    {
                        stillNotReachedEnd = false;
                        break;
                    }
                } 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] != -1) &&(arr[i] != 0))
                {
                    Console.Write("{0}, ", arr[i]);
                }

            }

        }
    }
}
