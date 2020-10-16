using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{

    class ClassAndObjects
    {
        static int SortArray(int[] arr)
        {
            int cash = 0;
            for (int i = 0; i < 10; i-1)
            {
                for (int n = 0; n < 10; n++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        cash = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = cash;
                        cash = 0;
                    }
                }
            }
        }
        static void GenerationArray(int[,] arr, int MinN, int MaxN)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    arr[i, n] = rnd.Next(MinN, MaxN);
                    Console.Write($"{arr[i, n]} ");
                }
                Console.WriteLine(" ");
            }
            return;
        }


        public static void CaO()
        {

            int sum = 0;
            int[,] array1 = new int[10, 10];
            int[] array2 = new int[10];
            GenerationArray(array1, 0, 10);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                        sum = sum + array1[i, n];
                }
                array2[i] = sum;
                Console.WriteLine($"{i+1} - {sum}");
                sum = 0;
            }

        }


    }
}
