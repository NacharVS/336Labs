using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilevcalculator
{
    class Vasilevcalculator
    {


        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Subtraction(double a, double b)
        {
            return a - b;
        }

        static double SqrtX(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Операции:");
            Console.WriteLine("Слож: " + Sum(a, b));
            Console.WriteLine("Вычит: " + Subtraction(a, b));

            Console.WriteLine("Умнож: " + Multiplication(a, b));
            Console.WriteLine("Дел: " + Division(a, b));

            Console.WriteLine("Квад: " + SqrtX(a, b));
            Console.ReadKey();
        }
    }
}