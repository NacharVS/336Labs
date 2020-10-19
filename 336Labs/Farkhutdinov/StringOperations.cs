using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
    class StringOperations
    {
        public static string _letters = "Stewardesses";
        public static void Delete(string Word)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(Word[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < Word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(Word[i]);
                }
            }
        }
    }
}
