using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Deligates
{
    class General
    {
        public void sort(int[] array)
        {
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
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();
        }
        public void sum(int[] array)
        {
            Random rmd = new Random();
            int tr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tr = tr + array[i];
            }
            Console.WriteLine($"{tr}");
        }
        public void max(int[] array)
        {
            Random rnd = new Random();
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = max + array[i];
                }
            }
            Console.WriteLine($"{max}");
        }
        public void sum2()
        {
            Random rnd = new Random();
        }
        public void raznost()
        {

        }
        public void proizvedenie(int[] a)
        {
            static double multyF(int n)
            {
               
                double p = 1;
                for (int k = 0; k < n; k++)
                    p = p * a[k];
                return p;
            }
    }
}
