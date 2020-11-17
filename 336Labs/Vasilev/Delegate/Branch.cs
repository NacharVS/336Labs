using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilev.Delegate
{
    class Branch
    {

       
            public static void GenerationArray(int[] arr, int MinN, int MaxN)
            {
                Console.Write($"GenArr:  ");
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
                Console.Write("Sort:    ");
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
                Console.Write("Sum:     ");
                int temp = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    temp = temp + arr[i];
                }
                Console.WriteLine($"{temp}");
            }

            public static void MaxArray(int[] arr)
            {
                Console.Write("Max:     ");
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
}
}
