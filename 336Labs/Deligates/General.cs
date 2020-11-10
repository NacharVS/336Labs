using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Deligates
{
    class General
    {
        public void Sort()
        { 
        
        }
        public void Sum()
        {

        }
        public void Max()
        {
            Random rnd = new Random();
            int[] arr = new int[7];
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = max + arr[i];
                }
               
            }


        }
        public void Sumdva()
        {
            Random rnd = new Random();
            int[] arr = new int[7];
            int[] arr2 = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 20);
                Console.WriteLine(arr);
                arr2[i] = rnd.Next(0, 20);
                Console.WriteLine(arr2);
            }
            int[] Sumdva = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Sumdva[i] = arr[i] + arr2[i];
                Console.WriteLine(Sumdva);
            }
           
        }
        public void Razn()
        {
            Random rnd = new Random();
            int[] arr = new int[7];
            int[] arr2 = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 20);
                Console.WriteLine(arr);
                arr2[i] = rnd.Next(0, 20);
                Console.WriteLine(arr2);
            }
            int[] Razn = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Razn[i] = arr[i] + arr2[i];
                Console.WriteLine(Razn);
            }
        }
        public void Proizv()
        {
            Random rnd = new Random();
            int[] arr = new int[7];
            int[] arr2 = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 20);
                Console.WriteLine(arr);
                arr2[i] = rnd.Next(0, 20);
                Console.WriteLine(arr2);
            }
            int[] Proizv = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Proizv[i] = arr[i] + arr2[i];
                Console.WriteLine(Proizv);
            }
        }
        
    }
}
