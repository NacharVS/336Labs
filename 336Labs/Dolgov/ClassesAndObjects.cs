using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class chiselki
    {
        int maxchis;
    }
    class ClassesAndObjects
    {
        static void Gen(int[,] array, int a, int b)
        {
            Random rnd = new Random();
            for (int c = 0; c < array.GetLength(0); c++)
            {
                for (int d = 0; c < array.GetLength(0); d++)
                {
                    array[c, d] = rnd.Next(a, b);
                    Console.Write($"{array[c, d]} ");
                }
                Console.WriteLine("");
            }
            return;
        }
        public static void ClaAndObj()
        {

        }
    }
}
