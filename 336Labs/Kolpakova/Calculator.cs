using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Выберите операцию - sum/sub/div/pow/sqrt: ");
            string SelectedAction = Console.ReadLine();
            Console.WriteLine($"Введите число А: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите число В: ");
            int b = int.Parse(Console.ReadLine());
            if (SelectedAction == "sqrt")
            {
                Console.WriteLine(Math.Sqrt(a));
            }

            else
            {
                switch (SelectedAction)
                {
                    case "sum":

                        Console.WriteLine(a + b);
                        break;
                    case "sub":
                        Console.WriteLine(a - b);
                        break;
                    case "div":
                        if (b == 0) Console.WriteLine($"На ноль делить нельзя!");
                        else
                        {
                            Console.WriteLine(a / b);
                        }
                        break;
                    case "pow":
                        Console.WriteLine(a * b);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                        {
                        }
                }

            }
        }
    }


    }
