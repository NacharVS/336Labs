using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
    class NumbersSumm
    {
        public int _number;
        public int _summ;
    }
    class ClassesAndObject
    {
        public static void ArrayGenerationSum(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
