using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i += 2)
            {
                Console.Write(word[i] + "");
            }
            Console.WriteLine();
            for (int i = 1; i < word.Length; i += 2)
            {
                Console.Write(word[i] + "");
            }
            Console.WriteLine();


        }
    }
}
