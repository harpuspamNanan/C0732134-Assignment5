using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732134_Assignment5
{
    class Program2
    {
        public static string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public static void Main()
        {
            Program2 orange = new Program2();
            Console.WriteLine(orange.Gematria("universe"));

            Console.ReadLine();
        }

        public int Gematria(string word)
        {
            int gematriaValue = 0;
            for (int i = 0; i < word.Length; i++)
                gematriaValue += LetterValue(word[i]);

            return gematriaValue;
        }




        public int LetterValue(char letter)
        {

            int x = 0;

            for (int i = 0; i < Letters.Length; i++)
            {
                if (Letters[i] == letter.ToString())
                    x += (i+1);
            }

            return x;           

        }
    }
}
