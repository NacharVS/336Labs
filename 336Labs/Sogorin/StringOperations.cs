using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class StringOperations
    {
        //кол-во слов:
        public static void Split(string s)
        {
            int i = 0;
            string[] wor = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in wor)
            {
                Console.WriteLine(item);
                i = i + 1;
            }
            Console.WriteLine(i);
        }
    }
}
/*
 * Console.WriteLine("Введите текст:");
            string s = Console.ReadLine();
            StringOperations.Split(s);
 */
