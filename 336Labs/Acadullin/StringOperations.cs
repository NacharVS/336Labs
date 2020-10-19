using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class StringOperations
    {
        public static void Parity(string simb)
        {
            Console.Write("Четные буквы:");
            for (int i = 0; i < simb.Length; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.Write(simb[i]);
                }
            }
            Console.WriteLine();

        }
        public static void LishSymbol(string simb)
        {
            for (int i = 0; i < simb.Length; i++)
            {
                if (i + 1 < simb.Length)
                { 
                 if (simb[i] != simb[i + 1])
            {
                Console.Write(simb[i]);   
            }
                }
            }
            Console.Write(simb[simb.Length - 1]);
        }   
    }
}
    

