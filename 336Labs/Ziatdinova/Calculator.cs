using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи число В");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Выбери действие - summa/subtract/div/multip");
            string SelectedAction = Console.ReadLine();

        }


        static int summa(int A, int B)
        {
            return A + B;
        }
        static int subtract(int A, int B)
        {
            return A - B;
        }
        static int div(int A, int B)
        {
            return A / B;
        }
        static int multip(int A, int B)
        {
            return A * B;
        }
        
    }
}
