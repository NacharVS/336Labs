using System;
using System.Collections.Generic;
using System.Text;
using _336Labs.Loginov.branсh;

namespace _336Labs.Loginov
{
    class Base
    {
        private delegate void Trainee(int[] mes);
        public static void B()
        {
            int[] array1 = new int[10];
            Trainee tr1;
            Branch.GenerationArray(array1, 0, 10);
            tr1 = Branch.SortArray;
            tr1 += Branch.SumArray;
            tr1 += Branch.MaxArray;
            tr1(array1);
        }
    }
}
