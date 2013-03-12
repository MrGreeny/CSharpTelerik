using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcatStrings
{
    class ConcatStrings
    {
        static void Main(string[] args)
        {
            //Exercise 07
            string hello = "Hello";
            string world = "World";
            object helloWorldObj = hello + " " + world;
            string helloWorldStr = (string)helloWorldObj;
            Console.WriteLine(helloWorldStr);  //Hello World
        }
    }
}
