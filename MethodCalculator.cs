﻿using System;

namespace MethodCalculator
{
    class MethodCalculator
    {
        static int Vicitanie(int a, int b)
        {
            return a - b;
        }
        static int Slozenie(int a, int b)
        {
            return a + b;
        }
        static int Delenie(int a, int b)
        {
            return a / b;
        }
        static int Umnozenie(int a, int b)
        {
            return a * b;
        }
        static int Kvadrat(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Vicitanie(1, 10));
            Console.WriteLine(Slozenie(1, 10));
            Console.WriteLine(Delenie(1, 10));
            Console.WriteLine(Umnozenie(1, 10));
            Console.WriteLine(Kvadrat(10));
        }
    }
}
