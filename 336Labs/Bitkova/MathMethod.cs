using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class MathMethod
    {
        static double Plus(double A, double B)
        {
            return A + B;
        }
        static double Minus(double A, double B)
        {
            return A - B;
        }
        static double Multiplication(double A, double B)
        {
            return A * B;
        }
        static double Division(double A, double B)
        {
            return A / B;
        }
        static double Pow(double A, double B)
        {
            return Math.Pow(A, B);
        }
        static double Pow1(double A, double B)
        {
            return Math.Pow(B, A);
        }
        static double Sqrt(double A)
        {
            return Math.Sqrt(A);
        }
        static double Sqrt1(double B)
        {
            return Math.Sqrt(B);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Сложение:");
            Console.WriteLine(Plus(A, B));
            Console.WriteLine("Вычитание:");
            Console.WriteLine(Minus(A, B));
            Console.WriteLine("Умножение:");
            Console.WriteLine(Multiplication(A, B));
            Console.WriteLine("Деление:");
            Console.WriteLine(Division(A, B));
            Console.WriteLine("А в степени В:");
            Console.WriteLine(Pow(A, B));
            Console.WriteLine("В в степени А:");
            Console.WriteLine(Pow1(B, A));
            Console.WriteLine("квадратный корень числа А:");
            Console.WriteLine(Sqrt(A));
            Console.WriteLine("квадратный корень числа В:");
            Console.WriteLine(Sqrt1(B));
        }
    }
}
