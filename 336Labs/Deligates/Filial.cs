using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Deligates
{
    class Filial
    {
        private delegate void Trainee();
        static void Main(string[] args)
        {
            Trainee tr1;
            tr1 = Delegate.sort;
            tr1();
            tr1 = Delegate.sum;
            tr1();
            tr1 = Delegate.max;
            tr1();
            Trainee tr2;
            tr2 = Delegate.sum2;
            tr2();
            tr2 = Delegate.raznost;
            tr2();
            tr2 = Delegate.proizvedenie;
            tr2();
        }
    }
}
