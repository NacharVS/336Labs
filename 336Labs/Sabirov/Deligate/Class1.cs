using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sabirov.Deligate
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[5, 5];
            Random rnd = new Random();

            for (int g = 0; g < massive.GetLength(0): g++)
            {
                for (int i = 0; i < massive.GetLength(0): g++)
                {
                    massive[g, i] = rnd.Next(10, 100);
                    Console.WriteLine($"{massive[g, i]");
                }
            }
        }
    }
}
