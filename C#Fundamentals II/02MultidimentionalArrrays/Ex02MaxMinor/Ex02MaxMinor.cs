using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02MaxMinor
{
    class Ex02MaxMinor
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();

            int[,] matrix = new int[9,12];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rand.Next(99);
                } 
            }
            PrintMatrix(matrix);

            //Console.WriteLine(rand.Next(19));

            int sum = 0;
            int indexI = 0; ;
            int indexJ = 0;
            for (int i = 0; i < matrix.GetLength(0) -3 ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) -3; j++)
                {
                    int tempSum = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            tempSum += matrix[i + k, j + l];
                        }
                    }

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        indexI = i;
                        indexJ = j;
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }

            Console.WriteLine("\n3x3 matrix with top left element at "+
            "position ({0},{1}) has the biggest sum of {2}", indexI, indexJ, sum);
        }
        static void PrintMatrix(int[,] matrix)
        {

            for (int p = 0; p < matrix.GetLength(0); p++)
            {
                for (int q = 0; q < matrix.GetLength(1); q++)
                {
                    if (matrix[p, q] < 10)
                    {
                        Console.Write("{0}   ", matrix[p, q]);
                    }
                    else if (matrix[p, q] > 9 && matrix[p, q] < 100)
                    {
                        Console.Write("{0}  ", matrix[p, q]);
                    }
                    else if (matrix[p, q] > 99 && matrix[p, q] < 1000)
                    {
                        Console.Write("{0} ", matrix[p, q]);
                    }

                }
                Console.WriteLine("");
            }
        }

    }

}
