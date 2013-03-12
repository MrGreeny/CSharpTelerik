using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FallingRocksTests
{
    class Program
    {
        //static int[][] rockMatrix;

        //static void InitializeRockMatrix()
        //{
        //    rockMatrix = new int[5][];

        //    for (int rows = 0; rows < rockMatrix.Length; rows++)
        //    {
        //        rockMatrix[rows] = new int[5];
        //    }
        //}

        //static void SetRocksMatrixToZero()
        //{
        //    for (int row = 0; row < rockMatrix.Length; row++)
        //    {
        //        for (int column = 0; column < rockMatrix[row].Length; column++)
        //        {
        //            rockMatrix[row][column] = 0;
        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            //for (int row = 0; row < rockMatrix.Length; row++)
            //{
            //    for (int column = 0; column < rockMatrix[row].Length; column++)
            //    {
            //        Console.WriteLine(rockMatrix[row][column]);
            //    }
            //    Console.WriteLine("\n");
            //}

            int[][] tri = new int[4][]; //create four null int[] elements
            for (int i = 0; i < tri.Length; i++)
            { // Length 4 (rows)
                tri[i] = new int[4];  // each row is a different length
            }
            for (int i = 0; i < tri.Length; i++)
            {
                for (int j = 0; j < tri[i].Length; j++)
                {
                    tri[i][j] = 0;
                }
                
            }
            for (int i = 0; i < tri.Length; i++)
            {
                for (int j = 0; j < tri[i].Length; j++)
                {
                    Console.Write(tri[i][j]);
                }
                Console.Write("\n");

            }

        }
    }
}
