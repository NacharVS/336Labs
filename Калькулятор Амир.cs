using System;


namespace Калькулятор
{
    class Program


    {

        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Dif(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static double VOZVIDENIE(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static double Koren(double a, double b)
        {
            return Math.Sqrt(a, b);
        }
        static void Main(string[] args)
            {
                Console.WriteLine("Введите числа:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Операции:");
                Console.WriteLine("Сумма: " + Sum(a, b));
                Console.WriteLine("Разность: " + Dif(a, b));
                Console.WriteLine("Умножение: " + Mul(a, b));
                Console.WriteLine("Деление: " + Div(a, b));
                Console.WriteLine("Возведение в степень: " + VOZVIDENIE(a, b));
                Console.WriteLine("Корень из: " + Koren(a, b));
            Console.ReadKey();

            }
        

}   }    
