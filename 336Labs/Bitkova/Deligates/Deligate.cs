using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Deligates
{
    class Deligate
    {
        public static void SortArray()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Сортировка:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
        }
        public static void ElementSum()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }

            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            Console.WriteLine("Cумма элементов массива:");
            Console.Write(sum);
            Console.WriteLine();
        }
        public static void MaxArray()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                if (max < array[i]) max = array[i];
            }
            Console.WriteLine("Максимальный элемент массива:");
            Console.Write(max);
            Console.WriteLine();
        }
        public static void Sum()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                array2[i] = rnd.Next(0, 10);
            }
                Console.WriteLine("Сумма массивов:");
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] + array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Minus()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                array2[i] = rnd.Next(0, 10);
            }
            Console.WriteLine("Разность массивов:");
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] - array2[i];
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Multiplus()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                array2[i] = rnd.Next(0, 10);
            }
            Console.Write("Произведение массивов:");

            Console.WriteLine();
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] * array2[i];
                
                 Console.Write(array3[i] + " ");
            }
        }
    }
}
