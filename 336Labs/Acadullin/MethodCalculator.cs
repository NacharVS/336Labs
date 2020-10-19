using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class MethodCalculator
    {
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Diff(double a, double b)
        {
            return a - b;
        }
        static double Comp(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static double Step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double FG(double a, double b)
        {
            double result = a;
            for (int i = 1; i <= b; i++)
            {
                result = result * i;
            }
            return result;
        }
        
        

    }
}
