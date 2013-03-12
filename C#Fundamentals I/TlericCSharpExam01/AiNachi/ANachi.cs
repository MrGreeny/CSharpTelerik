using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AiNachi
{
    class ANachi
    {
        //enum Letters {A=1,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,Z };
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            uint firstNumber = ((uint) first - 64);

            char second = char.Parse(Console.ReadLine());
            uint secondNumber = ((uint)second - 64);
            int rows = int.Parse(Console.ReadLine());

            uint temp;

            for (int i = 0; i < rows; i++)
            {
                if (i==0)
                {
                    Console.WriteLine(first);
                }
                else if (i == 1)
                {
                    Console.WriteLine("{0}{1}", second, (char)(((firstNumber + secondNumber)%26) + 64));
                    temp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = (secondNumber + temp)%26;
                    
                }
                else
                {


                    for (int j = 0; j < i + 1; j++)
                    {

                        if (j == 0)
                        {
                            Console.Write("{0}", (char)(((firstNumber + secondNumber) % 26) + 64));
                            temp = firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = (secondNumber + temp) % 26;
                        }
                        else if ( j == i)
                        {
                            Console.Write("{0}", (char)(((firstNumber + secondNumber) % 26) + 64));
                            temp = firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = (secondNumber + temp) % 26;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}
