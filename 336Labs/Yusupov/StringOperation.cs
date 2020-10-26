using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Yusupov
{
    class StringOperation
    {
        public static void main (string[] args )
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            string oddLetters = "";
            string evenLetters = "";
            int parametr  = 0; 
            foreach(char item in word  )
            {
               if (parametr % 2 ==0 )
                {
                    oddLetters += word[parametr ]; 

                }else
                {
                    evenLetters += word[parametr]; 
                }
                parametr++; 
            }
            Console.WriteLine("нечетное " + oddLetters );
            Console.WriteLine("четное "+  evenLetters );
        }
    }
}
