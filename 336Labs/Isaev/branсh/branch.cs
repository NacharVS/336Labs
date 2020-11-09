using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov.branсh
{
    class Branch
    {
        public static void GenerationArray(int[] arr, int MinN, int MaxN)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                    arr[i] = rnd.Next(MinN, MaxN);
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void SortArray(int[] arr)
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void SumArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = temp + arr[i];
            }
            Console.WriteLine($"{temp}");
        }

        public static void MaxArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    {
                    max = max + arr[i];
                    }
            }
            Console.WriteLine($"{max}");
        }










    }
}
