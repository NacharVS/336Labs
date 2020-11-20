using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Melenteva
{
    class Deligate
    {
        public static void GenerationArray(int[] arr, int Min, int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(Min, Max);
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
                {
                    Console.WriteLine();
                }
            } } }