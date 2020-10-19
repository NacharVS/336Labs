using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class StringOperations
    {
        public static void ShowWords (string s)
        {
            string[] words = s.Split("wodrs words");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
