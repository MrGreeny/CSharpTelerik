using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03StringSequence
{
    class Ex03StringSequence
    {
        static void Main(string[] args)
        {
            string[,] strArr = { { "hi", "ha", "ha", "hl" }, { "hi", "hi", "sd", "fo" }, { "hp", "hi", "hi", "fu" } };
            PrintMatrix(strArr);

            //The position of the starting element of the longest sequence
            int[] elements = new int[2];

            //Length of the maximal sequence
            int maxSeq = 0;
            int direction = -1;
            //0 - left
            //1 - down
            //2 - down/left
            int count = 1;

            //Here it gets hairi
            //first two fors is so we do the sequence for every ellement of the matrix
            for (int i = 0; i < strArr.GetLength(0); i++)
            {
                for (int j = 0; j < strArr.GetLength(1); j++)
                {
                    //So, for every element
                    //We go trough the three possible directions
                    for (int dir = 0; dir < 3; dir++)
                    {
                        if (dir == 0)//right
                        {

                            for (int l = 0; l < strArr.GetLength(1) - j; l++)
                            {
                                if (strArr[i, j] == strArr[i, j + l])
                                {
                                    count++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (count > maxSeq)
                            {
                                maxSeq = count - 1;
                                direction = 0;
                                elements[0] = i;
                                elements[1] = j;
                            }
                            count = 1;
                        }
                        else if (dir == 1)//bottom
                        {
                            for (int l = 0; l < strArr.GetLength(0) - i; l++)
                            {
                                if (strArr[i, j] == strArr[i + l, j])
                                {
                                    count++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (count > maxSeq)
                            {
                                maxSeq = count - 1;
                                direction = 1;
                                elements[0] = i;
                                elements[1] = j;
                            }
                            count = 1;
                        }
                        else if (dir == 2)//right bot diagonal
                        {
                            for (int l = 0; (l < strArr.GetLength(1) - j && l < strArr.GetLength(0) - i); l++)
                            {
                                if (strArr[i, j] == strArr[i + l, j + l])
                                {
                                    count++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (count > maxSeq)
                            {
                                maxSeq = count - 1;
                                direction = 2;
                                elements[0] = i;
                                elements[1] = j;
                            }
                            count = 1;
                        }
                    }
                }
            }
            //Console.WriteLine("Maximal sequence:{0}, starting element({1},{2}),Direction:{3} ", maxSeq, elements[0], elements[1], direction);
            
            //Prints the longest sequence
            if (direction == 0)
            {
                for (int i = 0; i < maxSeq; i++)
                {
                    Console.Write("{0}, ", strArr[elements[0],elements[1]+i]);
                }
            }
            else if (direction == 1)
            {
                for (int i = 0; i < maxSeq; i++)
                {
                    Console.Write("{0}, ", strArr[elements[0]+i, elements[1]]);
                }
            }
            else if (direction == 2)
            {
                for (int i = 0; i < maxSeq; i++)
                {
                    Console.Write("{0}, ", strArr[elements[0] + i, elements[1] +i]);
                }
            }

        }
        static void PrintMatrix(string[,] matrix)
        {

            for (int p = 0; p < matrix.GetLength(0); p++)
            {
                for (int q = 0; q < matrix.GetLength(1); q++)
                {
                    Console.Write("{0} ", matrix[p, q]);
                }
                Console.WriteLine("");
            }
        }

    }
}
