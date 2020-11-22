using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Deligates
{
    class Fillial
    {
        private delegate void Trainee();
        static void Main(string[] args)
        {
            Trainee tr1;
            tr1 = Deligate.SortArray;
            tr1();
            tr1 = Deligate.ElementSum;
            tr1();
            tr1 += Deligate.MaxArray;
            tr1();
            Trainee tr2;
            tr2 = Deligate.Sum;
            tr2();
            tr2 = Deligate.Minus;
            tr2();
            tr2 += Deligate.Multiplus;
            tr2();
        }
    }
}
