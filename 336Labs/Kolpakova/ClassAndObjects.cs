using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class ClassAndObjects
    {
        static void Massiv(int[,] array, int a, int b)
        {
            Random rndm = new Random();
            for (int c = 0; c < array.GetLength(0); c++)
            {
                for (int d = 0; c < array.GetLength(0); d++)
                {
                    array { c, d} = rndm.Next(a, b);
                    Console.Write($"[array{c,d}]");
                }
                Console.WriteLine("");
            }
            return;

        }
    }
}
