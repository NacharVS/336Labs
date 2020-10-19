using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class StringOperations
    {
        int count = 0;
        public static void StringDestribute()
        {
            //string[] text = "Money";
            //for (int i = 0; i < text.length; i++)
            //{
            //    if(i % 2 == 0)

            string[] words = "я хочу кушать";
            for (int i = 0; i < words.length; i++)
            {
                if (words[i] == 0)
                {
                    sum = sum + 1;
                }
            }
        }
    }


    static void Main(string[] args)
    {
        StringOperations StO = new StringOperations(); 
        StringOperations.StringDestribute(); 
    }
}