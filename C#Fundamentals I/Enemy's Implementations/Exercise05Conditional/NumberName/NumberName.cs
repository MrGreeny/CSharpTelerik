using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberName
{
    class NumberName
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            string name = "";
            
            if (num >= 0 && num <= 9 )
            {
                if (num == 0)
                {
                    name = "zero";
                }
                else
                {
                    name = GetDigit(num);
                }
            }
            else if (num >= 10 && num <= 99)
            {
                name = TwoDigits(num);
            }
            else if (num >= 100 && num <= 999)
            {
                name = GetDigit(num / 100);
                //if num is 100, 200 ...
                if (num % 10 == 0 && ((num / 10) % 10 == 0))
                {
                    name += " hundred ";
                }
                else
                {
                    name += " hundred and ";
                    name += TwoDigits(num - ((num / 100) * 100));
                }

            }
            else
            {
                Console.WriteLine("Invalid number.");
            }

            char[] a = name.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            name = new string(a);
            Console.WriteLine(name);
        }
        static string GetDigit(int num)
        {
            switch (num)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
        static string GetTens(int num)
        {
            switch (num)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
                default:
                    return "";
            }
        }
        static string Tens(int num)
        {
            switch (num)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    return "";
            }
        }
        static string TwoDigits(int num)
        {
            string name;
            if (num >= 10 && num <= 19)
            {
                name = Tens(num);
            }
            else
            {
                name = GetTens(num / 10);
                name += " ";
                name += GetDigit(num % 10);
            }
            return name;
        }
    }
}
