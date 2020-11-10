using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Yusupov.Delegate
{
    class Filial
    {
        
        private delegate void Calculator(int[] mass);
        static void Main(string[] args )
        {
            int[] mass = new int[5];
            Calculator calc1;
            Calculator calc2;
            calc1 = General.MassGeneration;
            calc1(mass);
            calc1 = General.Sort;
            calc1(mass);
            calc1 = General.SumMassive;
            calc1(mass);
            calc1 = General.MaxElements;
            calc1(mass);
        }
    }
}
