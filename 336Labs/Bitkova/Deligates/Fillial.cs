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
            tr1 = Deligate.MaxArray;
            tr1();
            tr1 = Deligate.Sum;
            tr1();
            tr1 = Deligate.Minus;
            tr1();
            tr1 = Deligate.Multiplus;
            tr1();

        }

    }
}
