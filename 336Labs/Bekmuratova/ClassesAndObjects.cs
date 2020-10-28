using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bekmuratova
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


                for (int n = 0; n < mass.GetLength(0); n++)
                {
                    mass[i, n] = rnd.Next(0, 10);
                    Console.WriteLine($"{mass[i, n]} ");
                    sum += mass[i, n];
                }
                Console.WriteLine("-- Sum = " + sum);
                sum = 0;
                Console.WriteLine();
            }

            {
                Console.WriteLine();
            }



        }
    }
}