using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    {
        private int[] data = new int[] { 2, 9, 6, 3, 7, 1, 8, 2 };

        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.MergeSort(0, 7);

            Console.ReadKey();
        }

        public void MergeSort(int low, int high)
        {
            if (low < high)
            {
                MergeSort(low, (low + high) / 2);
                MergeSort(((low + high) / 2) + 1, high);

                Merge(low, (low + high) / 2, high);
            }
        }

        public void Merge(int low, int mid, int high)
        {
            int[] temp = new int[data.Length];

            int i = low, h = low, j = mid + 1;

            while (h <= mid && j <= high)
            {
                if (data[h] <= data[j])
                {
                    temp[i] = data[h];
                    h++;
                }
                else
                {
                    temp[i] = data[j];
                    j++;
                }

                i++;
            }

            if (h > mid)
                for (int k = j; k <= high; k++)
                    temp[i++] = data[k];
            else
                for (int k = h; k <= mid; k++)
                    temp[i++] = data[k];

            for (int k = low; k <= high; k++)
            {
                data[k] = temp[k];
            }
        }
    }
}

