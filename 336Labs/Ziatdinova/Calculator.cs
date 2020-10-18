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
            Console.WriteLine("Выбери действие: '+' '-' 'div' '*'");
            string action = Console.ReadLine();




            switch (action)
            {
                case "+":
                    Console.WriteLine(A + B);
                    break;
                case "-":
                    Console.WriteLine(A - B);
                    break;
                case "/":
                    Console.WriteLine(A / B);
                    break;
                case "*":
                    Console.WriteLine(A * B);
                    break;
                case "div":
                    if (B == 0)
                        Console.WriteLine("неверно!недопустимое выражение");

                    else
                    {
                        Console.WriteLine(A / B);
                    }    
                    break;
                default:
                    Console.WriteLine("неверно!недопустимое выражение");
                    break;

            }
            Console.ReadLine();
        }






    }
}
 