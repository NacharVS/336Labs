using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class MethodCalculator
    {
        static double Sum(double NumberA)
        {
            Console.WriteLine("Введите число B");
            double NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            return NumberA + NumberB;
        }
        static double Sub(double NumberA)
        {
            Console.WriteLine("Введите число B");
            double NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            return NumberA - NumberB;
        }
        static double Mult(double NumberA)
        {
            Console.WriteLine("Введите число B");
            double NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            return NumberA * NumberB;
        }
        static double Div(double NumberA)
        {
            Console.WriteLine("Введите число B");
            double NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            return NumberA / NumberB;
        }
        static double Pow(double NumberA)
        {
            Console.WriteLine("Введите число B");
            double NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            return Math.Pow(NumberA, NumberB);
        }
        static double Sqrt(double NumberA)
        {
            Console.Write("Результат: ");
            return Math.Sqrt(NumberA);
        }
        public static void Calc()
        {
            int a = 0;
            while (a != 1)
            {
                Console.WriteLine("Введите число A");
                double NumberA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1. Сложить");
                Console.WriteLine("2. Вычесть");
                Console.WriteLine("3. Умножить");
                Console.WriteLine("4. Разделить");
                Console.WriteLine("5. Возвести в степень");
                Console.WriteLine("6. Найти квдратный корень");
                int Choise = Convert.ToInt32(Console.ReadLine());
                switch (Choise)
                {
                    case 1:
                        Console.WriteLine(Sum(NumberA));
                        break;
                    case 2:
                        Console.WriteLine(Sub(NumberA));
                        break;
                    case 3:
                        Console.WriteLine(Mult(NumberA));
                        break;
                    case 4:
                        Console.WriteLine(Div(NumberA));
                        break;
                    case 5:
                        Console.WriteLine(Pow(NumberA));
                        break;
                    case 6:
                        Console.WriteLine(Sqrt(NumberA));
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Продолжить Y/N");
                string ChoiseY = Console.ReadLine();
                if (ChoiseY == "N")
                    a = 1;

            }
        }
    }
}