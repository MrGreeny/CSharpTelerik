using System;

class PrintSequence2Min3
{
    static void Main()
    {
        for (int i = 2; i < 13; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}
