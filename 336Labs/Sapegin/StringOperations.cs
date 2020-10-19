using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sapegin
{
    class StringOperations
    {
        public static void Substring(string[] A)
        {

            int A = 0;
            int B = 0;
            string words = "Ваша реклама";
            Console.WriteLine(words);
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0) A = words[i];
                else B = words[i];

            }
            Console.WriteLine(A);




        }

    }
}
// я не понимаю, что выводится при компиляции