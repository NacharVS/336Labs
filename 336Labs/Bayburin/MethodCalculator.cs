using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bayburin
{
    class MethodCalculator
    {
        public static double q(double a, double b)
        {
            return a + b;
        }
         public static double w(double a, double b)
        {
            return a - b;
        }
        public static double e(double a, double b)
        {
            return a * b;
        }
        public static double r(double a, double b)
        {
            return a / b;
        }
        public static double t(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
