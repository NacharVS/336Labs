using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{ 
  class ClassesAndObjects
    {
        public static void Dvum(int[,] Array)
        {
            Random rnd = new Random();
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(0); j++)
                {
                    Array[i, j] = rnd.Next(100);
                    Console.WriteLine(Array[i, j]);
                }
            }

        }

    }
}
  
        

      

    