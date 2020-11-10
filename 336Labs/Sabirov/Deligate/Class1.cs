using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sabirov.Deligate
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] massive = new int[10];
            Random rnd = new Random();

            for (int g = 0; g < massive.GetLength(0); g++)
            {
                massive[g] = rnd.Next(10, 100);
                Console.Write($"{massive[g]} ");
            }
        }
        public static void GenerationArray(int[] arr, int Min, int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rnd.Next(Min, Max);
                Console.WriteLine($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}