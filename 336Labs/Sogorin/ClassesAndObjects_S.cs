using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class ClassesAndObjects_S
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5];
            int[] su = new int[5];
            Random r = new Random();
            int s2 = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int l = i;
                Console.Write($"{l} - ");
                int sum = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(0, 2);
                    Console.Write($"{mas[i, j]} ");
                    sum += mas[i, j];
                }
                Console.WriteLine("- summ row = " + sum);
                for (int c = 0; c < su.GetLength(0); c++)
                {
                    if (sum > s2)
                    {
                        s2 = sum;
                        su[c] = s2;
                    }
                    su[c] = sum;
                }
            }
            for (int i = 0; i < su.GetLength(0); i++)
            {
                Console.Write(su[i]);
            }

        }
    }
}

