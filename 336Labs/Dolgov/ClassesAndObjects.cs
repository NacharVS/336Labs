using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{

    class ClassesAndObjects
    {
        static void SortMas(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int n = i + 1; n < arr.Length; n++)
                {
                    if (arr[i] > arr[n])
                    {
                        temp = arr[i];
                        arr[i] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
            return;
        }
        static void Gen(int[,] array, int a, int b)
        {
            Random rnd = new Random();
            for (int c = 0; c < array.GetLength(0); c++)
            {
                for (int d = 0; d < array.GetLength(1); d++)
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

            int sum = 0;
            int[] mas1 = new int[10];
            int[,] mas2 = new int[10, 10];
            Gen(mas2, 0, 10);
            for (int i = 0; i < mas2.GetLength(0); i++)
            {
                for (int n = 0; n < mas2.GetLength(1); n++)
                {
                    sum = sum + mas2[i, n];
                }
                mas1[i] = sum;
                sum = 0;
            }
            SortMas(mas1);
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.WriteLine($"{i} - {mas1[i]}");
            }

        }
    }
}