using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class ClassesAndObjects
    {
        static void GenerationArray(int[,] arr, int MinN, int MaxN)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(0); n++)
                {
                    arr[i, n] = rnd.Next(MinN, MaxN);
                    Console.WriteLine($"{arr[i, n]} ");
                }
                Console.WriteLine(" ");
            }
            return;
        }

        public static void CaO()
        {
            int max = 0;
            int[,] array = new int[10, 10];
            GenerationArray(array, 0, 10);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int n = 0; n < array.GetLength(0); n++)
                {
                    if (max < array[i, n])
                    {
                        max = array[i, n];
                    }
                }
                Console.WriteLine($"{i + 1} - {max}");
                max = 0;
            }
        }

    }
}
