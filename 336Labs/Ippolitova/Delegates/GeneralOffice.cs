using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova.Delegates
{
    class GeneralOffice
    {
         public static void Max(int[] mass)
         {
            Random rnd = new Random();
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length-1; i++)
            {
                if (mass[i] > max)
                    max = mass[i];
            }
            Console.WriteLine(max);
         }
        
        public static void Sorted(int[] mass)
        {
            Random rnd = new Random();
            int sort = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
            }
            Console.WriteLine();
            for (int j = 0; j < mass.Length; j++)
            {


                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] > mass[i + 1])
                    {
                        sort = mass[i + 1];
                        mass[i + 1] = mass[i];
                        mass[i] = sort;
                    }

                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
                
        }

        public static void Summ(int[] mass)
        {
            Random rnd = new Random();
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] > 0)
                    summ += mass[i];
            }
            Console.WriteLine(summ);
        }

        public static void SummMass(int[] mass, int[] mass1)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                mass1[i] = rnd.Next(0, 100);
                mass[i] = mass[i] + mass1[i];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
            public static void DiffMass(int[] mass, int[] mass1)
            {
                Random rnd = new Random();
                
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(0, 100);
                    mass1[i] = rnd.Next(0, 100);
                    mass[i] = mass[i] - mass1[i];
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine(mass[i]);
                }

            }

        public static void MultiMass(int[] mass, int[] mass1)
        {
            Random rnd = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                mass1[i] = rnd.Next(0, 100);
                mass[i] = mass[i] * mass1[i];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }

        }
    }  
}
