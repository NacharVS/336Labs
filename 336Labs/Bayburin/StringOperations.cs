using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bayburin
{
    class StringOperations
    {
        //Чётные и нечётные.
        public static void StringEven(string word)
        {
            Console.Write("odd letters -  ");
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine();
            Console.Write("even letters - ");
        
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine();


        }
        //Кол-во слов в строке.
        public static void numberofwords(string theword)
        {
            int words = 1;
            for (int i = 0; i < theword.Length; i++)
            {
                if (char.IsWhiteSpace(theword[i]))
                {
                    words++;
                }
               
                
            }
            Console.WriteLine($"Number of words: {words}");
        }
        //Палиндром
       
        
            

        }
    }


