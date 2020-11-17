using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilev.Deligate
{
    class GeneralOffice
    {
        private delegate void Trainee(int[] arr);
        private delegate void Traineee(int[] arr1, int[] arr2);
        public static void B()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Trainee tr1;
            Console.WriteLine("Arr for Number 1");
            Branch.GenerationArray(array1, 0, 10);
            tr1 = Branch.SortArray;
            tr1 += Branch.SumArray;
            tr1 += Branch.MaxArray;
            Traineee tr2;
            Console.WriteLine("Arr for Number 2");
            Branch.GenerationArray(array2, 0, 10);
            Branch.GenerationArray(array3, 0, 10);
            tr2 = Branch.SumTwoArray;
            tr2 += Branch.DiffTwoArray;
            tr2 += Branch.MultTwoArray;

            
            Console.WriteLine("Номер1");
            tr1(array1);
            Console.WriteLine("Номер2");
            tr2(array2, array3);

        }
    }
}
    }
}
