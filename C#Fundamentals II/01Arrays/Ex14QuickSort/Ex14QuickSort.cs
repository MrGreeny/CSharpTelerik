//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Ex14QuickSort
//{
//    class Ex14QuickSort
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 4,8,1,4,9,2,66,8,23,15,82,11,5,27};
//        }
//        static int[] QuickSort(int[] array)
//        {
//            if (array.Length >= 1)
//            {
//                //Console.WriteLine("array sorted");
//                return array;
//            }
//            else
//            {
//                int leftIndex = 0;
//                int rightIndex = array.Length;
//                int pivot = (array.Length) / 2;
//                //int[] arrLeft = new int[pivot];
//                //int[] arrRight = new int[pivot -1];
//                List<int> arrLeft = new List<int>();
//                List<int> arrRight = new List<int>();


//                for (int i = 0; i < array.Length; i++)
//                {
//                    if (array[i] <= array[pivot])
//                    {
//                        arrLeft.Add( array[i]);
//                    }
//                    else 
//                    {
//                        arrRight.Add(array[i]);
//                    }
//                }

//            }
//        }
//    }
//}
