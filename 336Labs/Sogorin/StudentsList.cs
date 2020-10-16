using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    public class StudentsList
    {
        public string _name;
        public double _MathMa;
        public double _RussMa;
        public double _phisMa;
        public StudentsList(string name, double math, double rus, double phis)
        {
            _name = name;
            _MathMa = math;
            _RussMa = rus;
            _phisMa = phis;
        }
    }
    public class Stsel
    {
        public static void Sel(StudentsList[] list, double Avma)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._MathMa + list[i]._phisMa + list[i]._RussMa)/3 >= Avma)
                {
                    Console.WriteLine($"{list[i]} is sucssefull");
                }
            }
        }
    }
}
