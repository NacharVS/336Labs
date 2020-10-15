using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bayburin
{
    class NumbersSumm
    {
        public int _number;
        public int summ;
    }
    class ClassesAndObject
    {
        static void ArrayGeneration(int[] array)
        {
            int[,] mass = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
        }
    }
}
