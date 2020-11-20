using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova.Deligates
{
    class Class2
    {
        public static void SumTwoArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[10];
            Console.Write("SumTwo: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.WriteLine($"{arr3[i]} ");
            }
            Console.WriteLine();

        }
        public static void DiffTwoArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[10];
            Console.Write("DiffTwo: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.Write($"{arr3[i]} ");
            }
            Console.WriteLine();
        }
    }
}
