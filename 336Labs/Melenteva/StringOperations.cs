using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Melenteva
{
    class StringOperations
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string slovo = Console.ReadLine();
            string oddLetters = "";
            string evenLetters = "";
            int parametr = 0;
            foreach (char item in slovo)
            {
                if (parametr % 2 == 0)
                {
                    oddLetters += slovo[parametr];

                }
                else
                {
                    evenLetters += slovo[parametr];
                }
                parametr++;
            }
            Console.WriteLine("oddletters " + oddLetters);
            Console.WriteLine("evenletters " + evenLetters);

        }
    }
}
