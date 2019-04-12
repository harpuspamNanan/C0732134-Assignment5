using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732134_Assignment5
{
    class Program
    {

        public static void Main(string[] args)
        {
            Program a = new Program();

            Console.Write("the longest word is : "); 
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));

            Console.ReadLine();
        }


        public string MyFunctionA(string input)
        {
            // Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');

            int takeLengthOfFirstWord = 0, takeLengthOfSecondWord = 0;
            int wordArrayLength = words.Length;
            string max = "";

            int[] wordsLength = new int[wordArrayLength];

            for (int i = 0; i < wordArrayLength-1; i++)
            {
                takeLengthOfFirstWord = words[i].Length;                // This will take the Length of first word , Later will move to the next word
                takeLengthOfSecondWord = words[i + 1].Length;           // This will take Length of proceeding Word , and will carry on till the End Word

                if (takeLengthOfFirstWord > takeLengthOfSecondWord)         // Here we are comparing whether first letter's length is greater than Adjacent word
                    max = words[i];                                         // Here we are storing the longest word of the two. It will be replaced as soon as it encounters another long word
            }

            return max;
            
        }

        

    }
}


    
