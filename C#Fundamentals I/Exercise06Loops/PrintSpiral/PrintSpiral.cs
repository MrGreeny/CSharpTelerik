using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintSpiral
{
    class PrintSpiral
    {
        static void Main(string[] args)
        {
            //Hardest exercise so far... pfew...
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix;
            int iterNum = n;
            if (n > 20)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                matrix = new int[n, n];
                int row = 0;
                int column = 0;
                int steps = n-1;
                int oddEven = 1;
                int cycleFour = 0;
                int checkSteps = 0;

                for (int val = 0; val <n * n; val++)
                {
                    //If we made the nessecary number of seps
                    //then we make a turn
                    if (checkSteps == steps)
                    {
                        //change direction
                        checkSteps = -1; 
                        cycleFour++;
                        oddEven++;

                        //Steps change every other iteration.
                        if (oddEven % 2 == 0)
                        {
                            //decrement steps to the next turn
                            steps--;
                        }
                    }
                    //the counter that holds the number of steps since the last
                    //turn
                    checkSteps++;

                    //Asigning the value to the matrix field
                    matrix[row, column] = val + 1;

                    //each turn the variable what changes is different
                    //the cycle is four turns
                    if (cycleFour % 4 == 0)
                    {
                        column++;
                    }
                    else if (cycleFour % 4 == 1)
                    {
                        row++;
                    }
                    else if (cycleFour % 4 == 2)
                    {
                        column--;
                    }
                    else if (cycleFour % 4 == 3)
                    {
                        row--;
                    }   
                }

                //Printing the array
                for (int p = 0; p < n; p++)
                {
                    for (int q = 0; q < n; q++)
                    {
                        if (matrix[p,q] < 10)
                        {
                            Console.Write("{0}   ", matrix[p, q]);
                        }
                        else if (matrix[p,q] > 9 && matrix[p,q] < 100)
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
}
