using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncreaseVariable
{
    class IncreaseVariable
    {
        static void Main(string[] args)
        {
            int varType;
            
            do
            {
                Console.WriteLine("What type is the variable? 1-int, 2-double, 3-string;");
                varType = int.Parse(Console.ReadLine());
            } while ( (varType != 1) && (varType != 2) && (varType != 3) );
            Console.WriteLine("Enter the number:");

            switch (varType)
            {
                case 1:
                    int intNum = int.Parse(Console.ReadLine());
                    ++intNum;
                    Console.WriteLine(intNum);
                    break;
                case 2:
                    double doubleNum = double.Parse(Console.ReadLine());
                    doubleNum += 1.0;
                    Console.WriteLine(doubleNum);
                    break;
                case 3:
                    string str = Console.ReadLine();
                    str += "*";
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
        }
    }
}
