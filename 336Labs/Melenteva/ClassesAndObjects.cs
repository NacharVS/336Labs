﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Melenteva
{
    class ClassesAndObjects
    {
        static void Gen(int[,] array, int g, int i)
        {
            Random rnd = new Random();

            for (m = 0; m < array.GetLength(0); m++)
            {
                for (int n = 0; n < array.GetLength(0); n++)
                {
                    array[m, n] = rnd.Next(g, i);
                    Console.WriteLine($"{array[m, n]} ");
                }
                Console.WriteLine("");


            }
            return;
        }
    }
}
