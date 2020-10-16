using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Yusupov
{
    class Method_Calculator
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Mult(int a, int b)
        {
            return a * b;

        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Divid(int a , int b  )
        {
            return a / b; 

        }
        static void Main(String[] args)
        {
            Console.WriteLine("Введите число a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Cумма : "+ Sum(a, b));
            Console.WriteLine("Разность: "+ Sub(a, b));
            Console.WriteLine("Произведение: " + Mult(a, b));
            Console.WriteLine("Частное: "+ Divid (a,b )); 
        }

    }
}

