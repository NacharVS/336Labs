using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov.Branch
{
    class Br
    {
        public static void GA(int[] ar, int Min, int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                ar[i] = rnd.Next(Min, Max);
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public static void SA(int[] ar)
        {
            int TE;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int n = i + 1; n< ar.Length; n++)
                {
                    if (ar[i] > ar[n])
                    {
                        TE = ar[i];
                        ar[i] = ar[n];
                        ar[n] = TE;
                    }
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public static void SumAr(int[] ar)
        {
            int TE = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                TE = TE + ar[i];
            }
            Console.WriteLine($"{TE}");
        }
        public static void MaxAr(int[] ar)
        {
            int max = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (max < ar[i]);
                    {
                    max = max + ar[i];
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

