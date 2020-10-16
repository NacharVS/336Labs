using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace _336Labs.Acadullin
{
    class ClassesAndObjects
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[6, 6];
            Random rnd = new Random();
            int max = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(10, 50);
                    Console.Write($"{mass[i, j]} ");
                    if (max < mass[i, j])
                        max = mass[i, j];
                }
                Console.WriteLine();
            }
        }

    }
}

