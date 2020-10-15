using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class MethodCalc
    {


        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Dif(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static double VOZVEDENIE(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static double Koren(double a)
        {
            return Math.Sqrt(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вычисления:");
            Console.WriteLine("Сумма = " + Sum(a, b));
            Console.WriteLine("Вычитание =" + Dif(a, b));
            Console.WriteLine("Умножение = " + Mul(a, b));
            Console.WriteLine("Деление = " + Div(a, b));
            Console.WriteLine("Возведение в степень = " + VOZVEDENIE(a, b));
            Console.WriteLine("Корень из = " + Koren(a));
            Console.ReadKey();
        }
    }
}