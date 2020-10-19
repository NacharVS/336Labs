using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class StringOperations
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            string oddLetters = "";
            string evenLetters = "";
            int index = 0;
            foreach(char item in word)
            {
                if (index % 2 == 0)
                {
                    oddLetters += word[index];
                }
                else
                {
                    evenLetters += word[index];
                }
                index++;
            }
            Console.WriteLine("Нечетное " + oddLetters);
            Console.WriteLine("Четное" + evenLetters);
           
            {

            }
        }
    }
}
