using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIfSubsetIsZero
{
    class CheckIfSubsetIsZero
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers\nFirst: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Third: ");
            int third = int.Parse(Console.ReadLine());
            Console.Write("Fourth: ");
            int fourth = int.Parse(Console.ReadLine());
            Console.Write("Fifth: ");
            int fifth = int.Parse(Console.ReadLine());
            int[] arr = { first, second, third, fourth, fifth };

            //int[] test = { 3, -1, 1, 2, -5 };
            Console.WriteLine(OneAddition(arr)+TwoAdditions(arr)+ThreeAdditions(arr)+FourAdditions(arr));




        }

        static string OneAddition(int[] arr)
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i] + arr[j] == 0)
                    {
                        result += string.Format("({0},{1}) ", arr[i],arr[j]);
                    }
                }
            }
            return result;
        }

        static string TwoAdditions(int[] arr)
        {
            string result = "";
            bool timeToStop = false;
            for (int i = 0; i < 5; i++)
            {
                if (timeToStop)
                {
                    break;
                }
                for (int j = 0; j < 5; j++)
                {
                    if (timeToStop)
                    {
                        break;
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0 && i != j && i != k && j != k)
                        {

                            result += string.Format("({0},{1},{2}) ", arr[i], arr[j], arr[k]);
                            timeToStop = true;
                            break;
                        }
                    }
                }
            }
            return result;
        }//two
        
    static string ThreeAdditions(int[] arr)
    {
        bool timeToStop = false;
        string result = "";
        for (int i = 0; i < 5; i++)
        {
            if (timeToStop)
            {
                break;
            }
            for (int j = 0; j < 5; j++)
            {
                if (timeToStop)
                {
                    break;
                }
                for (int k = 0; k < 5; k++)
                {
                    if (timeToStop)
                    {
                        break;
                    }
                    for (int l = 0; l < 5; l++)
                    {
                        if (arr[i] + arr[j] + arr[k] + arr[l] == 0 &&
                            i != j && i != k && i != l &&
                            j != k && j != l &&
                            k != l)
                        {
                             result += string.Format("({0}, {1}, {2}, {3}) ", arr[i], arr[j], arr[k],arr[l]);
                             timeToStop = true;
                             break;
                        }
                    }
                }
            }
        }
        return result;
    }

    static string FourAdditions(int[] arr)
    {
        bool timeToStop = false;
        string result = "";
        for (int i = 0; i < 5; i++)
        {
            if (timeToStop)
            {
                break;
            }
            for (int j = 0; j < 5; j++)
            {
                if (timeToStop)
                {
                    break;
                }
                for (int k = 0; k < 5; k++)
                {
                    if (timeToStop)
                    {
                        break;
                    }
                    for (int l = 0; l < 5; l++)
                    {
                        if (timeToStop)
                        {
                            break;
                        }
                        for (int m = 0; m < 5; m++)
                        {
                            if (arr[i] + arr[j] + arr[k] + arr[l] + arr[m] == 0 &&
                                i != j && i != k && i != l && i != m &&
                                j != k && j != l && j != m &&
                                k != l && k != m &&
                                l != m)
                            {
                                result += string.Format("({0},{1},{2},{3},{4}) ", arr[i], arr[j], arr[k], arr[l], arr[m]);
                                timeToStop = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
        return result;
    }


    }//class
}//namespace


