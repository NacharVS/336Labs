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
            int sum = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            { 
                int a = i;
                Console.Write($"{a} - ");

                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(0, 10);
                    Console.Write($"{mass[i, j]} ");
                    sum += mass[i, j];
                }
            }
            {
                Console.WriteLine("-- Сумма =  " + sum);
                Console.WriteLine();
            }
        }

    }
}

