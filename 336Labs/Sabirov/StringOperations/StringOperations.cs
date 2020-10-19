using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sabirov
{
    public class StringOperations
    {
        public static string _letters = "We want to zhrat";

        public static void Concatenation(string s, string f)
        {
            Console.WriteLine(String.Concat(s, f));
        }
        public static void searchInLetters(string s, string f)
        {
            Console.WriteLine(s.IndexOf(f));
        }
    }
    
 
   
    

}
