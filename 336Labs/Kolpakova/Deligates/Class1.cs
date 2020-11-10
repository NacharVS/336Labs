using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova.Deligates
{
    class Class1
    {
        public static void GenerationArray(int[] arr, int Min, int Max)
        { 
            Random rndm = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rndm.Next(Min, Max);
                Console.WriteLine($"(arr[i])");
            }
            Console.WriteLine();
        }
        public static void SortArray(int[] arr)
        {
            int tem;
            for (int i = 0; i < arr.Length - 1; i++)
            {
               for (int n = i + 1; n < arr.Length; n++)
                {
                    if (arr[i] > arr[n])
                    {
                        tem = arr[i];
                        arr[i] = arr[n];
                        arr[n] = tem;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();

            }

            
        }
    } 
    


        
        

        


    
}
