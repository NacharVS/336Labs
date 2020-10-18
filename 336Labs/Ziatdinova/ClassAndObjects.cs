using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova
{
    class ClassAndObjects
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько строк?");
            Random rndm = new Random();
            int len = Convert.ToInt32(Console.ReadLine()), sum = 0;
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                {
                    array [i] = rndm.Next(0, 100);
                    sum += array[i];
                    Console.WriteLine((i + 1) + "-" + array[i]);
                }
                Console.WriteLine("Сумма цифр" + sum);
                int[] sortArray = new int[len];
                Array.Copy(array, sortArray, len);
                Array.Sort(sortArray);
                for (int i = 0; i < len; i++)
                { 
                    for (int j = 0; j < len; j++)
                    {
                        if (sortArray[i] == array[j])
                        {
                            Console.WriteLine(j + 1);
                        }
                    }
                }
            }
            

        }
    }
}
