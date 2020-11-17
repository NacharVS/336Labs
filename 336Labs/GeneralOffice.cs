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
            Branch1.GenerationArray(array1, 0, 10);
            tr1 = Branch1.SortArray;
            tr1 += Branch1.SumArray;
            tr1 += Branch1.MaxArray;
            Traineee tr2;
            Console.WriteLine("Arr for Number 2");
            Branch1.GenerationArray(array2, 0, 10);
            Branch1.GenerationArray(array3, 0, 10);
            tr2 = Branch2.SumTwoArray;
            tr2 += Branch2.DiffTwoArray;
            tr2 += Branch2.MultTwoArray;

            //Вывод
            Console.WriteLine("Number1");
            tr1(array1);
            Console.WriteLine("Number2");
            tr2(array2, array3);

        }
    }
}
    }
}
