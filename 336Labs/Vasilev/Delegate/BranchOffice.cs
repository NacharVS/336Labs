using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilev.Deligate
{
    class BranchOffice
    {
       public static void sum()
        {
            Random rnd = new Random();
            int[] array = new int[5];
            int[] array2 = new int[5];
            for (int i=0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.WriteLine(array);
                array2[i] = rnd.Next(0, 10);
                Console.WriteLine(array2);
            }
            int[] array3 = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] + array2[i];
                Console.WriteLine("Сложение массивов" + array3[i]);
            }
        }
    }
}
