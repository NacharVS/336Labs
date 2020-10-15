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
            Random r = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(0, 1);
                    sum = mas[i, j] + mas[i + 1, j];
                    Console.WriteLine($"{mas[i, j]} ");
                    Console.WriteLine("summ row = " + sum);
                }
            }

        }
    }
}

