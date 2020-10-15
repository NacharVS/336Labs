using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    public static void main(String[] args)
    {

   

    }
    class ClassAndObjects
    {
         static  void Arrayfill()
        {
            int[,] mass = new int[10,10];
            Random rand = new Random(); 
            for(int i = 0; i<mass.Length; i++ )  {
                for(int j = 0; j<mass.Length; j++)
                {
                    mass[i, j] = rand.Next(); 

                }

            }
            static int Sum()
            {

            }

        }
    }

}


