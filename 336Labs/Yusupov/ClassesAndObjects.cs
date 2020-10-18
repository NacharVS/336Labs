using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace _336Labs.Yusupov
{
    class ClassesAndObjects
    {
        public int sum = 0;
        public void ArrGenerate()
        {
            int[] sum = new int[5];
            int[,] Arr = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(0); j++)
                {
                    Arr[i, j] = rnd.Next(0, 10);
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(0); j++)
                {
                    sum[i] += Arr[i, j];
                }
                Console.WriteLine(sum[i]);
            }
            Array.Sort(sum);
            Console.WriteLine();

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                Console.WriteLine(sum[i]);
            }
        }

        static void Main(string[] args)
        {
            ClassesAndObjects obj = new ClassesAndObjects();
            obj.ArrGenerate();

        }
    }
}
  

