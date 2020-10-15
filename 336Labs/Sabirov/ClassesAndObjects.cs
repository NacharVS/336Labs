using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sabirov
{
    class ClassesAndObjects
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[10, 5];
            Random rnd = new Random();

            for (int g = 0; g < massive.GetLength(0); g++)
            {
                for (int i = 0; i < massive.GetLength(0); i++)
                {
                    massive[g, i] = rnd.Next(10, 100);
                    Console.WriteLine($"{massive[g, i]}$");

                }
                Console.WriteLine();

            }
            int sum = 0;
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                sum = massive[i, i] + sum;
            }
            Console.WriteLine(sum);

    }   }
}
