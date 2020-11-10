using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Deligates
{
    class General
    {
        public void sort()
        {
            int[] array = new int[4];
            Random rnd = new Random();
            int tr;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int n = i + 1; n < array.Length; n++)
                {
                    if (array[i] > array[n])
                    {
                        tr = array[i];
                        array[i] = array[n];
                        array[n] = tr;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Сортировка = " + array[i]);
            }
            Console.WriteLine();
        }
        public void sum()
        {
            int[] array = new int[4];
            Random rmd = new Random();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("Сумма = " + sum);
        }
        public void max()
        {
            int[] array = new int[4];
            Random rnd = new Random();
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = max + array[i];
                }
            }
            Console.WriteLine("Максимум = " + max);
        }
        public void sum2()
        {
            Random rnd = new Random();
            int[] array = new int[4];
            int[] array2 = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 20);
                Console.WriteLine(array2);
            }
            int[] arraySum = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                arraySum[i] = array[i] + array2[i];
                Console.WriteLine("Сумма = " + arraySum);
            }
        }
        public void raznost()
        {
            Random rnd = new Random();
            int[] array = new int[4];
            int[] array2 = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 20);
                Console.WriteLine(array2);
            }
            int[] arraySum = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                arraySum[i] = array[i] - array2[i];
                Console.WriteLine("Разность = " + arraySum);
            }
        }
        public void proizvedenie(int[] a)
        {
                Random rnd = new Random();
                int[] array = new int[4];
                int[] array2 = new int[4];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 20);
                    Console.WriteLine(array);
                    array2[i] = rnd.Next(0, 20);
                    Console.WriteLine(array2);
                }
                int[] arraySum = new int[4];
                for (int i = 0; i < array.Length; i++)
                {
                    arraySum[i] = array[i] * array2[i];
                    Console.WriteLine("Произведение = " + arraySum);
                }
            }
    }
}
