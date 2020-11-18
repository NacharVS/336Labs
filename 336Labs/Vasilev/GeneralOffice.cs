using _336Labs.Vasilev.Delegate;
using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilev.Deligate
{
    class GeneralOffice
    {
        private delegate void Trainee(int[] arr);
        private delegate void Trainee2(int[] arr1, int[] arr2);
        public static void B()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Trainee tr1;
            Console.WriteLine("Arr для номера 1");
            Branch1.GenerationArray(array1, 0, 10);
            tr1 = Branch1.SortArray;
            tr1 += Branch1.SumArray;
            tr1 += Branch1.MaxArray;
            Trainee2 tr2;
            Console.WriteLine("Arr для номера 2");
            Branch2.GenerationArray(array2, 0, 10);
            Branch2.GenerationArray(array3, 0, 10);
            tr2 = Branch2.SumTwoArray;
            tr2 += Branch2.DiffTwoArray;
            tr2 += Branch2.MultTwoArray;

            
            Console.WriteLine("Номер1");
            tr1(array1);
            Console.WriteLine("Номер2");
            tr2(array2, array3);

        }
    }
}
    

