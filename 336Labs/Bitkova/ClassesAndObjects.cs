using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class ClassesAndObjects
    {
        public int sum = 0;
        public void arrayGenerate()
        {
            int[] sum = new int[5];
            int[,] array = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum[i] += array[i, j];
                }
                Console.WriteLine(sum[i]);
            }
            Array.Sort(sum);
            Console.WriteLine();

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                Console.WriteLine(sum[i]);
            }
        }

        static void Main(string[] args)
        {
            ClassesAndObjects obj = new ClassesAndObjects();
            obj.arrayGenerate();

        }
    }
}
