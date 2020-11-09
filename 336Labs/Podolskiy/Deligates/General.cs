using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy.Deligates
{
    class General
    {
        
       public static void Sort(int[] mass)
        {
            
            Random rnd = new Random();
            int temp;
            for (int i = 0; i < mass.Length-1; i++)
            {
                mass[i] = rnd.Next(0,100);
            
                 for (int n = i+1; n <mass.Length;n++)
                {
                    if (mass[i]> mass[n])
                    {
                        temp = mass[i];
                        mass[i] = mass[n];
                        mass[n] = temp; 
                    }
                }
            }
            return; 
        }
    }
}
