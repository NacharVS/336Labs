using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Melenteva
{
    class MethodCalculator
    {
        static double amount(double a, double b)
        {
            return a + b;
        }

        static double subtraction(double a, double b)
        {
            return a - b;
        }

        static double multiplication(double a, double b)
        {
            return a * b;
        }

        static double division(double a, double b)
        {
            return a / b;
        }
        public static void Calculator()
        {
            {
                int ab = 0;
                while (ab != 1)
                {
                    Console.WriteLine("Result:");
                    Console.WriteLine("Write a number A");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Write a number B");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Amount = " + amount(a, b));
                    Console.WriteLine("Subtraction = " + subtraction(a, b));
                    Console.WriteLine("Multiplication = " + multiplication(a, b));
                    Console.WriteLine("Division = " + division(a, b));
                    

                }

            }

        }

    }
}
