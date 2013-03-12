using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitName
{
    class DigitName
    {
        static void Main(string[] args)
        {
            int dig;
            do
            {
                Console.WriteLine("Enter digit");
                dig = int.Parse(Console.ReadLine());
                
            } while ( (dig < 0) || (dig > 9) );

            switch (dig)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("No such digit");
                    break;
            }
            
        }
    }
}
