using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Yusupov.Delegate
{
    class General
    {
        public static void MassGeneration(int[] mass)
        {
            Random rnd = new Random();
            Console.WriteLine("Cгенерированный массив: ");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine();
        }
        public static void Sort(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length - 1; i++)
            {


                for (int n = i + 1; n < mass.Length; n++)
                {
                    if (mass[i] > mass[n])
                    {
                        temp = mass[i];
                        mass[i] = mass[n];
                        mass[n] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: ");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
        public static void SumMassive(int[] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum = sum + mass[i];
            }
            Console.WriteLine("Сумма массива " + sum);
        }
        public static void MaxElements(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i])
                {
                    max = max + mass[i];
                }
            }
            Console.WriteLine("Максимальный элемент: " + max);
        }
    }
}
