using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova.Delegates
{
    class GeneralOffice
    {
         public static void Max(string[] args)
         {
            int[] mass = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length-1; i++)
            {
                if (mass[i] > mass[i + 1])
                    Console.WriteLine($" {mass[i]}!");
            }
         }

        public static void Sorted(string[] args)
        {
            if 
        }
    }  
}
