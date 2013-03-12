using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocksGame
{
    class FallingRocksGame
    {
        /// <summary>
        /// Basicaly, the solution generates a matrix with zeroes with lenght
        /// and width - the length and width of the console.
        /// After that the MoveRocksDown() assigns to every row of the
        /// matrix (starting from the last) the number of the previous row,
        /// and in this way the new matrix is moved downwards.
        /// To the 0-th row is assigned a new array with random numbers.
        /// Then the matrix is processed by the PrintRocks() method and
        /// for the coresponding values are printed the assigned chars.
        /// 
        /// For example such a matrix:
        /// 
        /// rockMatrix[0]= {0 0 1 0 0 2}
        /// rockMatrix[1]= {6 0 0 8 0 0}
        /// rockMatrix[2]= {2 0 0 0 0 0}
        /// 
        /// gives these characters on the player screen
        /// 
        /// 0 0 ^ 0 0 @
        /// % 0 0 # 0 0
        /// @ 0 0 0 0 0
        /// 
        /// </summary>


        static int width = Console.WindowWidth/2;
        static int height = Console.WindowHeight;
        static int playerPosition = width / 2 - 1;
        static int[][] rockMatrix;
        static Random random = new Random();
        static int score = 0;
        static int highscore = 0;
        //Lowering the gapFrequency makes the game harder!
        static int initialGapFrequency = 35;
        static int gapFrequency = initialGapFrequency;

        ///Generates and returns an array with numbers between 0 and 11, that
        ///corespond the different types of rocks
        static int[] GenerateRow()
        {
            //int numberOfRocksOnARow = random.Next(0, width / rockFrequency);
            int[] newRow = new int[width];

            for (int i = 0; i < newRow.Length; i++)
            {
                //for every element of the array, that willl become the new row
                // an element between 0 and gapfrequency-1 is generated,
                //if this element is 0, than we put a random number btetween
                //0 and 11 on the coresponding position
                int toPutANumber = random.Next(0,gapFrequency);
                if (toPutANumber == 0)
                {
                    int randomRockNumber = random.Next(0, 12);
                    newRow[i] = randomRockNumber;
                }
            }
            return newRow;
        }//GenerateRow()

        static void MoveRocksDown()
        {
            for (int i = height - 1; i > 0; i--)
            {
                rockMatrix[i] = rockMatrix[i - 1];
            }
            //assigning new random row to the 0-th row.
            rockMatrix[0] = GenerateRow();
        }//MoveRocksDown()

        //Creates a matrix rockMatrix[Height][Width]
        //It's a jagged two dimensional array
        static void CreateRockMatrix()
        {
            rockMatrix = new int[height][];
            for (int rows = 0; rows < rockMatrix.Length; rows++)
            {
                rockMatrix[rows] = new int[width];
            }
        }//CreateRockMatrix()

        //Initializes the matrix to be all zeroes
        static void SetRocksMatrixToZero()
        {
            for (int row = 0; row < rockMatrix.Length; row++)
            {
                for (int column = 0; column < rockMatrix[row].Length; column++)
                {
                    rockMatrix[row][column] = 0;
                }
            }
        }//SetRocksMatrixToZero()

        static void DetectCollision()
        {
            if (rockMatrix[height - 1][playerPosition] != 0 ||
                rockMatrix[height - 1][playerPosition + 1] != 0 ||
                rockMatrix[height - 1][playerPosition + 2] != 0)
            {
                if (score > highscore)
                {
                    highscore = score;
                }

                Console.SetCursorPosition(9, height / 2);
                Console.Write("Game Over! Score: {0}", score);
                Console.ReadKey();
                score = 0;
                gapFrequency = initialGapFrequency;
                SetRocksMatrixToZero();
            }
            else score++;
        }


        //Runs trough each element of the rockMatrix and draws a character
        //corresonding to the number that is the element
        //HERE BE COLORS
        static void PrintRocks()
        {
            for (int row = 0; row < rockMatrix.Length; row++)
            {
                for (int column = 0; column < rockMatrix[row].Length; column++)
                {
                    //This switch puts a different character
                    //depending on the number in the matrix.
                    switch (rockMatrix[row][column])
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            PrintAtPosition(column, row, '^');
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            PrintAtPosition(column, row, '@');
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            PrintAtPosition(column, row, '*');
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            PrintAtPosition(column, row, '&');
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            PrintAtPosition(column, row, '+');
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            PrintAtPosition(column, row, '%');
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            PrintAtPosition(column, row, '$');
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Green;
                            PrintAtPosition(column, row, '#');
                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Red;
                            PrintAtPosition(column, row, '!');
                            break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.Red;
                            PrintAtPosition(column, row, '.');
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.White;
                            PrintAtPosition(column, row, ';');
                            break;
                        default:
                            break;
                    }
                    //Console.ResetColor();
                }
            }
        }//DetectCollision()

        //Draws the player character (0)
        static void DrawPlayer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            PrintAtPosition(playerPosition, height - 1, '(');
            PrintAtPosition(playerPosition + 1, height - 1, '0');
            PrintAtPosition(playerPosition + 2, height - 1, ')');
        }//DrawPlayer()

        static void DrawField()
        {
            for (int i = 0; i < height; i++)
            {
                PrintAtPosition(width+1, i, '|');
                Console.SetCursorPosition(width+10, 2);
                Console.Write("Score: {0}", score);

                Console.SetCursorPosition(width + 10, 3);                
                Console.Write("Highscore: {0}", highscore);

                Console.SetCursorPosition(width + 10, 4);
                Console.Write("Level: {0}", score/100);

                ////HERE BE CAT. Cats are awesome!
                Console.SetCursorPosition(width + 10, 5);
                Console.Write("  |\\_/|");
                Console.SetCursorPosition(width + 10, 6);
                Console.Write(" / @ @ \\");
                Console.SetCursorPosition(width + 10, 7);
                Console.Write("( > º < )");
                Console.SetCursorPosition(width + 10, 8);
                Console.Write(" `»»x««´");
                Console.SetCursorPosition(width + 10, 9);
                Console.Write(" /  O  \\");
            }
        }

        static void MovePlayerRight()
        {
            if (playerPosition < width - 3)
            {
                playerPosition++;
            }
        }//MovePlayerRight()

        static void MovePlayerLeft()
        {
            if (playerPosition > 0)
            {
                playerPosition--;
            }
        }//MovePlayerLeft()

        static void ClearScrollBars()
        {
            Console.BufferHeight = height;
            //Console.BufferWidth = width;
        }//ClearScrollBars()

        //Prints characters on given positions
        static void PrintAtPosition(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        static void DoNotStopConsole()
        {
                            if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MovePlayerLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MovePlayerRight();
                    }
                }
        }
         

        static void Main(string[] args)
        {

            CreateRockMatrix();
            SetRocksMatrixToZero();
            while (true)
            {
                if (score % 100 == 0)
                {
                    if (gapFrequency > 0)
                    {
                        gapFrequency -= 2; //making the game harder
                    }
                }

                DoNotStopConsole();
                Console.Clear();
                DrawField();
                ClearScrollBars();
                MoveRocksDown();
                DetectCollision();
                PrintRocks();
                DrawPlayer();
                Thread.Sleep(150);
            }
        }
    }
}
