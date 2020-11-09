using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Deligates
{
    class Deligate
    {
        public static void SortArray()
        {
            Random rnd = new Random();
            int[] array = new int[7];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 50);
            }

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void ElementSum()
        {

        }
        public void MaxArray()
        {

        }
        public void sum()
        {

        }
        public void minus()
        {

        }
        public void Multiplus()
        {

        }
    }
}
