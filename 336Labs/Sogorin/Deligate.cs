using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{   
    public class Deligate
    {
        public static void mas(int[] mass, int[] mass0)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 4);
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass0.Length; i++)
            {
                mass0[i] = rnd.Next(0, 4);
                Console.Write($"{mass0[i]} ");
            }
            Console.WriteLine();            
        }
        //
        public static void sortmas(int[] mass)
        {            
            int num = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                num = mass[i];
                for (int j = 1; j < mass.Length; j++)
                {
                    if (num <= mass[j])
                    {
                        num = mass[j];
                        mass[i] = mass[j];
                    }
                }
                
            }
            Console.WriteLine($" {mass}");
        }
        //
        public static void summas(int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
               summ += mass[i];
            }
            Console.WriteLine($"сумма строки = {summ}");
        }
        //
        public static void maxmas(int[] mass)
        {
            Console.WriteLine($" {mass}");
        }
    }
    class Delmass
    {
        public static void sumdualmas(int[] mass, int[] mass2)
        {
            Console.WriteLine($" {mass} {mass2}");
        }
        public static void disdualmas(int[] mass, int[] mass2)
        {
            Console.WriteLine($" {mass} {mass2}");
        }
        public static void umdualmas(int[] mass, int[] mass2)
        {
            Console.WriteLine($" {mass} {mass2}");
        }
    }
}


/*
int[] mass1 = new int[4];
int[] mass2 = new int[4];
Deligate.mas(mass1, mass2);
            Trainee tr1;
//tr1 = Deligate.summas;
tr1 = Deligate.sortmas;
tr1(mass1);
Tramass tr2;
tr2 = Delmass.disdualmas;
tr2(mass1, mass2);
*/
