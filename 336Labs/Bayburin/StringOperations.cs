using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bayburin
{
    class StringOperations
    {
        public static string _letters = "Stewardesses";
        public static void Delete(string Word)
        {

            Console.WriteLine(Word.Replace("ss", "s"));
            Console.WriteLine(Word.Replace("es", "s"));
            Console.WriteLine(Word.Replace("es", ""));
        }

    }
}
