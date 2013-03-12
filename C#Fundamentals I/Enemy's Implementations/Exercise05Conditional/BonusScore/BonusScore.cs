using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 9:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    num *= 10;
                    Console.WriteLine("End score : {0}", num);
                    break;
                case 4:
                case 5:
                case 6:
                    num *= 100;
                    Console.WriteLine("End score : {0}", num);
                    break;
                case 7:
                case 8:
                case 9:
                    num *= 1000;
                    Console.WriteLine("End score : {0}",num);
                    break;                
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
