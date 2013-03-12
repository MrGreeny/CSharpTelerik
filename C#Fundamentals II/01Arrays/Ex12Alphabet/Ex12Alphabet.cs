using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex12Alphabet
{
    class Ex12Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();
            char[] wordArr = new char[word.Length];
            int index;

            //Copying each letter in a cell of an array
            for (int i = 0; i < word.Length; i++)
            {
                wordArr[i] = (char)word[i];   
            }

            //Finding and printing the indices of the leters
            for (int i = 0; i < wordArr.Length; i++)
            {
                index = FindLetterIndex(wordArr[i]);
                if (index != -1)
                {
                    Console.Write("{0} ", index);
                }
                else
                {
                    //If the character isn't an uppercase letter we print
                    //a placeholder @
                    Console.Write("@ ", index);
                }
 
            }


        }

        //This function creates an array with the letters A-Z
        //and returns the index of the given letter
        static int FindLetterIndex(char letter)
        {
            int index = -1;
            char[] alphabet = new char[27];
            //We begin with 1, so the indexes match the number of the letter
            for (int i = 1; i < alphabet.Length; i++)
            {
                //ASCII table
                alphabet[i] = (char)(i + 64);
            }

            for (int i = 1; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
