﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{

    class ClassAndObjects
    {
        static void SortArray(int[] arr)
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


        public static void GenerationArray(int[,] arr, int MinN, int MaxN)
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
            int[] sumArr = new int[10];
            int[] array2 = new int[10];
            int[,] array1 = new int[10, 10];
            GenerationArray(array1, 0, 10);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    sum = sum + array1[i, n];
                    sumArr[i] = sum;
                }
                array2[i] = sum;
                sum = 0;
            }
            SortArray(array2);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{i} - {sumArr[i]}   {array2[i]}");
            }

        }


    }
}