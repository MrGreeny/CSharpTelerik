using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks
{
    static List<string> rocksList = new List<string>();
    static List<string> collisionDetectionCoordinates = new List<string>();
    static string rowStonesXCoordinates = "";
    static int dwarfXPosition = 0;
    static Random randomGenerator = new Random();
    static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
    static int score = 0;
    static int level = 70;
    static int levelCount = 1;
    static int nextLevelCriteria = 100;

    static void Main()
    {
        RemoveScrollBars();
        SetInitialPositions();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }

            Console.Clear();

            if (rocksList.Count - 1 == Console.WindowHeight - 1) //There is a row of rocks just above the dwarf
            {
                //analyze if the dwarf is hit
                if (IsDwarfHit(dwarfXPosition, collisionDetectionCoordinates[rocksList.Count - 1]))
                {
                    //Dwarf is hit, clear the game-field and stop the game
                    rocksList.Clear();
                    collisionDetectionCoordinates.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 4, Console.WindowHeight / 2);
                    Console.WriteLine("Game Over!");
                    Console.SetCursorPosition(Console.WindowWidth / 4, 1 + Console.WindowHeight / 2);
                    Console.WriteLine("Your score is {0}. You reached level {1} ({2}%).", score, levelCount, level);

                    //Clear the score and level information
                    score = 0;
                    level = 70;
                    levelCount = 1;
                    nextLevelCriteria = 100;

                    //Allow the player to start new game
                    Console.SetCursorPosition(Console.WindowWidth / 4, 3 + Console.WindowHeight / 2);
                    Console.WriteLine("Press any key to start new game.");
                    Console.ReadKey();

                }
                else
                {
                    //Dwarf survived, remove the last row
                    rocksList.RemoveAt(Console.WindowHeight - 1);
                    collisionDetectionCoordinates.RemoveAt(Console.WindowHeight - 1);
                    score++;

                    //increase the difficulty
                    if (score > nextLevelCriteria && level < 101)
                    {
                        level = level + 5;
                        levelCount++;
                        nextLevelCriteria = nextLevelCriteria + 100;
                    }
                }

            }

            //Add the next rock
            rocksList.Insert(0, GenerateRockRow(out rowStonesXCoordinates));
            collisionDetectionCoordinates.Insert(0, rowStonesXCoordinates);

            //Draw all rocks
            for (int i = 0; i < rocksList.Count; i++)
            {
                PrintStringAtPosition(0, i, rocksList[i]);
            }

            DrawDwarf();

            Thread.Sleep(150);
        }

    }

    static bool IsDwarfHit(int dwarfXPosition, string row)
    {
        bool result = false;

        if (row.Length == 1)
        {
            return false;
        }

        string[] rocksPositions = row.Split(',');

        for (int i = 1; i < rocksPositions.Length; i = i + 2)
        {
            if ((dwarfXPosition < Int32.Parse(rocksPositions[i]) && Int32.Parse(rocksPositions[i]) < dwarfXPosition + 3)
                || (dwarfXPosition < Int32.Parse(rocksPositions[i + 1]) && Int32.Parse(rocksPositions[i + 1]) < dwarfXPosition + 3))
            {
                result = true;
                break;
            }
        }

        return result;
    }

    static string GenerateRockRow(out string rowStonesXCoordinates)
    {
        string row = new string(' ', Console.WindowWidth - 1);
        int rockWidth = randomGenerator.Next(1, 4); //number between 1 and 3
        int rocksCount = randomGenerator.Next(1, 5);  //number between 1 and 4

        int rockXPos = 0;
        int randomPercent = randomGenerator.Next(1, 101);
        if (0 < randomPercent && randomPercent <= level)
        {
            List<int> rowStonesXCoordinatesList = new List<int> { rocksCount };
            for (int i = rocksCount; i > 0; i--)
            {
                //generate the rock type
                int rockType = randomGenerator.Next(0, rocks.Length);
                rockXPos = randomGenerator.Next(rockXPos, (Console.WindowWidth - 1) - i * rockWidth);
                rowStonesXCoordinatesList.Add(rockXPos);
                rowStonesXCoordinatesList.Add(rockXPos + rockWidth);
                row = ReplaceAt(row, rockXPos, new string(rocks[rockType], rockWidth));
                rockXPos = rockXPos + rockWidth;
            }
            //Format:
            //number of rock blocks,block1_start,block1_end,block2_start,block2_end ...
            rowStonesXCoordinates = string.Join(",", rowStonesXCoordinatesList);
        }
        else
        {
            rowStonesXCoordinates = "0";
        }
        return row;
    }

    static void MoveDwarfLeft()
    {
        if (dwarfXPosition > 0)
        {
            dwarfXPosition--;
        }
    }

    static void MoveDwarfRight()
    {
        if (dwarfXPosition < Console.WindowWidth - 3 - 1)
        {
            dwarfXPosition++;
        }
    }

    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void PrintStringAtPosition(int x, int y, string stringToPrint)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(stringToPrint);
    }

    static void DrawDwarf()
    {
        char[] dwarf = { '(', '0', ')' };
        for (int i = 0; i < dwarf.Length; i++)
        {
            PrintAtPosition(dwarfXPosition + i, Console.WindowHeight - 1, dwarf[i]);
        }
    }

    static void SetInitialPositions()
    {
        dwarfXPosition = Console.WindowWidth / 2 - 2;
    }

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static string ReplaceAt(string inputString, int startingIndex, string newSubString)
    {
        if (inputString == null)
        {
            throw new ArgumentNullException("input");
        }
        StringBuilder builder = new StringBuilder(inputString);
        char[] chars = newSubString.ToCharArray();
        for (int i = startingIndex, j = 0; i < startingIndex + newSubString.Length; i++, j++)
        {
            builder[i] = chars[j];
        }

        return builder.ToString();
    }
}
