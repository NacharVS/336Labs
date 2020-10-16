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
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Операции:");
            Console.WriteLine("Сумма: " + Sum(a, b));
            Console.WriteLine("Разность: " + Diff(a, b));
            Console.WriteLine("Умножение: " + Comp(a, b));
            Console.WriteLine("Деление: " + Div(a, b));
            Console.WriteLine("Взведение в степень: " + Step(a, b));
            Console.ReadKey();
        }

    }
}
