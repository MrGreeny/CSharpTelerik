using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenLandNumbers2
{
    class SevenLand2
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int number = int.Parse(str);
            int[] arr = new int[str.Length];

            bool sixes = true;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i].ToString());
                if (arr[i] != 6)
                {
                    sixes = false;
                }
            }

            bool takeOver = false;

            int count = arr.Length-1;

            if (!sixes)
            {



                do
                {
                    if (arr[count] == 6)
                    {
                        arr[count] = 0;
                        takeOver = true;
                    }
                    else
                    {
                        arr[count]++;
                        takeOver = false;
                    }
                    count--;
                    if (count == 0 && arr[count] == 6 && takeOver)
                    {
                        sixes = true;

                    }

                } while (takeOver);

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
            }
            else
            {
                Console.Write("1");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("0");
                }
            }



            //Console.WriteLine(number);
        }

    }
}
