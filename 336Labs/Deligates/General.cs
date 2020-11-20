using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Deligates
{
    class General
    {
        public static void GenArr(int[] ar, int Min, int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                ar[i] = rnd.Next(Min, Max);
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public static void SortArr(int[] arr)
        {
            int Tmp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int n = i + 1; n < arr.Length; n++)
                {
                    if (arr[i] > arr[n])
                    {
                        Tmp = arr[i];
                        arr[i] = arr[n];
                        arr[n] = Tmp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void SumArr(int[] arr)
        {
            int Tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Tmp = Tmp + arr[i];
            }
            Console.WriteLine($"{Tmp}");
        }
        public static void MaxAr(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) ;
                {
                    max = max + arr[i];
                }
            }
            Console.WriteLine($"{max}");
        }
    }
    class Branch2
    {
        public static void SumTwoArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[10];
            Console.Write("SumTwo:  ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.Write($"{arr3[i]} ");
            }
            Console.WriteLine();
        }

        public static void DiffTwoArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[10];
            Console.Write("DiffTwo: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] - arr2[i];
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
        }
        public static void MultTwoArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[10];
            Console.Write("MultTwo: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
                Console.Write($"{arr3[i]} ");
            }
            Console.WriteLine();
        }
    }
}