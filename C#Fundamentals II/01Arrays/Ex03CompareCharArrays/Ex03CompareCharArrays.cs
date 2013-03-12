using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03CompareCharArrays
{
    class Ex03CompareCharArrays
    {
        static void Main(string[] args)
        {
            
            char[] charrArr1 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'Q' };
            char[] charrArr2 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'Q', 'P' };
            
            //Equal arrays
            //char[] charrArr1 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'Q' };
            //char[] charrArr2 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'Q' };

            //Second is bigger
            //char[] charrArr1 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'Q' };
            //char[] charrArr2 = { 'a', 'b', 'a', 'S', 'A', 'G', 'P', 'R' };

            //length is the length of the smallest array
            int length = 0;
            int isBigger = 0;
            // isBigger is 1 when first array is bigger, 2 when second array is bigger
            //and 0 if they are equal

            if (charrArr1.Length > charrArr2.Length)
            {
                length = charrArr2.Length;
                isBigger = 1;
            }
            else if (charrArr1.Length < charrArr2.Length)
            {
                length = charrArr1.Length;
                isBigger = 2;
            }
            else
            {
                length = charrArr1.Length;
                isBigger = 0;
            }


            for (int i = 0; i < length; i++)
            {
                //Algorytm compares the ASCII numbers of the chars
                if ( (int) charrArr1[i] > (int) charrArr2[i] )
                {
                    Console.WriteLine("First array is bigger (lexicographically)");
                    break;
                }
                else if ((int) charrArr1[i] < (int) charrArr2[i])
                {
                    Console.WriteLine("Second array is bigger (lexicographically)");
                    break;
                }
                //We go in this if, if all the characters are equal and we reached the 
                //end of the array
                else if (((int)charrArr1[i] == (int)charrArr2[i]) && ( i == length - 1) )
                {
                    if (isBigger == 1)
                    {
                        Console.WriteLine("First array is bigger (lexicographically)");
                        break;
                    }
                    else if (isBigger == 2)
                    {
                        Console.WriteLine("Second array is bigger (lexicographically)");
                        break;
                    }
                    else if (isBigger == 0)
                    {
                        Console.WriteLine("Both arrays are equal (lexicographically)");
                        break;
                    }
                }
            }

        }
    }
}
