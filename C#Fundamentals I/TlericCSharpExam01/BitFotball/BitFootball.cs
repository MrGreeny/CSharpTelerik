using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitFotball
{
    class BitFootball
    {

        static void Main(string[] args)
        {
            int[,] grid = new int[8, 8];
            int number;
            string readStr;

            //populating team 1
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                readStr = Console.ReadLine();
                number = int.Parse(readStr);
                for (int j = grid.GetLength(1) - 1; j >= 0; j--)
                {
                    grid[i, j] = number % 2;
                    number /= 2;
                }
            }

            //populating team two
            int[,] gridTwo = new int[8, 8];
            
            for (int i = 0; i < gridTwo.GetLength(0); i++)
            {
                readStr = Console.ReadLine();
                number = int.Parse(readStr);
                for (int j = gridTwo.GetLength(1) - 1; j >= 0; j--)
                {
                    gridTwo[i, j] = number % 2;
                    number /= 2;
                }
            }


            //PrintGrid(grid);
            //changing values of grid two to 2s
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (gridTwo[i,j] == 1)
                    {
                        gridTwo[i,j] = 2;
                    }
                }
            }

            //PrintGrid(gridTwo);
            

            //Detecting collision
            // int i = 8; i>0m
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grid[i,j] == 1 && gridTwo[i,j]==2)
                    {
                        grid[i, j] = 0;
                        gridTwo[i, j] = 0;
                    }
                    
                }
            }
            
            //adding gridtwo to grid
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (gridTwo[i,j] == 2)
                    {
                        grid[i, j] = 2;
                    }
                }
            }

            //PrintGrid(grid);
            int hasOnes;
            int hasTwos;
             int goalsTeamOne = 0;
             int goalsTeamTwo = 0;



            for (int j = 0; j < 8; j++)//each column
            {
                hasOnes = 0;
                hasTwos = 0;

                for (int i = 0; i < 8; i++)//each row
                {
                    if (grid[i,j] == 1)
                    {
                        hasOnes++;
                    }
                    
                    if (grid[i,j] == 2)
                    {
                        hasTwos++;
                    }
                }
                if (hasOnes  > 0 && hasTwos ==0)
                {
                    goalsTeamOne++;
                }
                
                if (hasTwos >0 && hasOnes == 0) 
                {
                    goalsTeamTwo++;
                }

                hasOnes = 0;
                hasTwos = 0;
            }

            Console.WriteLine("{0}:{1}", goalsTeamOne, goalsTeamTwo);

        }
        static void PrintGrid(int[,] grid)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ", grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
