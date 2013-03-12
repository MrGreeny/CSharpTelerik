using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikLogo3
{
    class Logo3
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int height = 2 * x - 1 + x - 1;
            int width = 2 * (x + ((x + 1) / 2) - 1) - 1;

            char[,] arr = new char[height,width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i,j] = '.';
                }
            }


            int counter = x ;
            int offset = 0;
            int center = width / 2;
            int rowstoswitch = 0;
            //bool cont = true;
            //rombcheto pochva ot 2*n-1 i svurshva v rows
            while (counter <= height)
            {
                arr[counter -1, (center +offset) ] = '*';
                arr[counter -1 , (center - offset)] = '*';
                counter++;
                rowstoswitch++;

                if (rowstoswitch < x)
                {
                    offset--;
                }
                else
                {
                    offset++;
                }
            }



            counter = x;
            offset = 0;

            while (counter > 0)
            {
                arr[counter - 1, (center + offset)] = '*';
                arr[counter - 1, (center - offset)] = '*';
                counter--;
                offset++;   
            }


            counter = 1;
            offset = x-1;// za 5 e 4
            while (counter <= (x+1)/2)
            {
                arr[counter - 1, (center + offset)] = '*';
                arr[counter - 1, (center - offset)] = '*';
                counter++;
                offset++; 
            }



            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write( arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
