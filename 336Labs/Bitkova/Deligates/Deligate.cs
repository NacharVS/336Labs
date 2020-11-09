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

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Сортировка массива - " + array[i]);
            }
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
                Console.WriteLine(array);
            }
            
            Console.WriteLine("Сумма элеиентов массива - " + sum);
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
                Console.WriteLine(array);
            }
            
            Console.WriteLine("Максимальный элемент массива - " + max);
        }
        public static void Sum()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 10);
                Console.WriteLine(array2);
            }
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] + array2[i];
                Console.WriteLine("Сумма двух массивов" + array3[i]);
            }
        }
        public static void Minus()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 10);
                Console.WriteLine(array2);
            }
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] - array2[i];
                Console.WriteLine("Разность двух массивов" + array3[i]);
            }
        }
        public static void Multiplus()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 10);
                Console.WriteLine(array2);
            }
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] * array2[i];
                Console.WriteLine("Умножение двух массивов" + array3[i]);
            }
        }
    }
}
