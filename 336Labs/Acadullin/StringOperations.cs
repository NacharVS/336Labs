using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class StringOperations
    {
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
            Console.Write("--Удалены повторяющие буквы");
            
        }
        public static void Parity(string simb)
            {
                Console.Write("Нечетные буквы:");
                for (int i = 0; i < simb.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(simb[i]);
                    }
                }
                Console.WriteLine();
                Console.Write("Четные буквы:");
                for (int i = 0; i < simb.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(simb[i]);
                    }

                }
            }
            public static void Koliches(string simb)
            {
                int Slovo = 1;
                for (int i = 0; i < simb.Length; i++)
                {
                    if (char.IsWhiteSpace(simb[i]))
                    {
                        Slovo++;
                    }
                }
                Console.WriteLine($"Кол-во слов: {Slovo}");
            }

            public static void Palindrom(string simb)
            {
                string Abc = "ккалиина этоо ммашшинаа";
                string reverseAbc = "";
                for (int i = Abc.Length - 1; i > 0; i--)
                {
                    reverseAbc += Abc[i];
                }
                if (Abc == reverseAbc)
                    Console.WriteLine("Текст являеться палиндромом");
                else
                    Console.WriteLine("Текст не являеться палиндромом");
                Console.ReadKey();
            }
        }
}

    

