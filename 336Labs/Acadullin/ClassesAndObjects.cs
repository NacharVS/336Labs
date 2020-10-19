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
        public static void array(int[,] mass)
        { 
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
                    sum += mass[i , j];
                }
                Console.Write("-- Сумма =  " + sum);
                sum = 0;
                Console.WriteLine();
            }
            {
                
                Console.WriteLine();
            }
        }

    }
}

