using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class StringOperations
    {
        //1
       public static void StringRazdelit(string sg)
        {
            Console.Write("Нечетные: ");
            for (int i = 0; i < sg.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(sg[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Четные: ");
            for (int i = 0; i < sg.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(sg[i]);
                }
            }
        }
        //2
        public static void OdnaSymbol(string sg)
        {
            for (int i = 0; i < sg.Length; i++)
            {
                if (i+1 < sg.Length)
                {
                    if (sg[i] != sg[i + 1])
                    {
                        Console.Write(sg[i]);
                    }
                }
            }
            Console.Write(sg[sg.Length - 1]);
        }
       
        //4 
        public static bool Palindrom (string a)
        {
            for (int i = 1, j = a.Length - 1; i < j; i++, j--)
                if (a[i] != a[j])
                    return false;
            return true;
        }
    }
}
