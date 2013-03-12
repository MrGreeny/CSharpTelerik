using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Ex01Matrices
{
    class Ex01Matrices
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //Case a)
            int[,] columnMatrix = new int[size, size];
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    columnMatrix[j, i] = count;
                    count++;
                }
            }
            //PrintMatrix(columnMatrix);

            //Case b)
            int[,] invColumnMatrix = new int[size, size];
            count = 1;
            int turnArround = 0;
            for (int i = 0; i < size; i++)
            {
                turnArround++;
                if (turnArround %2 != 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        invColumnMatrix[j, i] = count;
                        count++;
                    }
                }
                else
                {
                    for (int j = size-1; j >= 0; j--)
                    {
                        invColumnMatrix[j, i] = count;
                        count++;
                    }
                }

            }
            //PrintMatrix(invColumnMatrix);

            //Case C
            int[,] diagonalMatrix = new int[size, size];
            count = 1;
            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    diagonalMatrix[size - i + j - 1, j] = count;
                    count++;
                }
            }

            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    diagonalMatrix[i - j, size - j - 1] = count;
                    count++;
                }
            }
            PrintMatrix(diagonalMatrix);

            //int[,] testMatrix = new int[size, size];
            //count = 1;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        testMatrix[i,j] = count;
            //        count++;
            //    }
            //}

            //PrintMatrix(testMatrix);
            //Console.WriteLine(testMatrix[1,2]);


        }
        static void PrintMatrix(int[,]matrix)
        {
            int n = matrix.GetLength(0);

            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
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
