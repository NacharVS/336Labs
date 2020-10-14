using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class MethodCalculator
    {
        static double Сумма(double a, double b)
        {
            return a + b;
        }

        static double Вычитание(double a, double b)
        {
            return a - b;
        }

        static double Умножение(double a, double b)
        {
            return a * b;
        }

        static double Деление(double a, double b)
        {
            return a / b;
        }

        static double Корень(double a, double b)
        {
            return Math.Sqrt(a);
        }
        static double Квадрат(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public static void Calculator()
        {
            {
                int abs = 0;
                while (abs != 1)
                {
                    Console.WriteLine("Введите число А");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите число Б");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:");
                    Console.WriteLine("Сложение = " + Сумма(a, b));
                    Console.WriteLine("Вычитание = " + Вычитание(a, b));
                    Console.WriteLine("Умножение = " + Умножение(a, b));
                    Console.WriteLine("Деление = " + Деление(a, b));
                    Console.WriteLine("Квадрат = " + Квадрат(a, b));
                    Console.WriteLine("Корень = " + Корень(a, b));
                    Console.WriteLine("Продолжить Yes/No");
                    string Choise = Console.ReadLine();
                    if (Choise == "No")
                        abs = 1;
                }
            }
        }
    }
}
