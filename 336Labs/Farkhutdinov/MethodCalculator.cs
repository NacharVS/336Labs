using System;
using System.Collections.Generic;
using System.Text;

namespace MethodCalculator.Farkhutdinov
{
        class MethodCalculator
        {
            public static double Addition(double a, double b)
            {
                return a + b;
            }
            public static double Subtraction(double a, double b)
            {
                return a - b;
            }
            public static double Multiplication(double a, double b)
            {
                return a * b;
            }
            public static double Division(double a, double b)
            {
                return a / b;
            }
            public static double Power(double a, double b)
            {
                return Math.Pow(a, b);
            }
            public static double Root(double a)
            {
                return Math.Sqrt(a);
            }
            public static int Factorial(int a)
            {
                if (a == 0)
                    return 1;
                return a * Factorial(a - 1);
            }
        }
}
