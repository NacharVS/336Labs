using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class StringOperation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удаление повторяющихся символов");
            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();
            int i = 0;
            while (true)
            {
                var tmp = str[i].ToString();
                str = str.Replace(tmp, "");
                str = str.Insert(i, tmp);
                i++;
                if (str.Length - 1 < i)
                    break;
            }
            Console.WriteLine(str);
            Console.WriteLine();

            Console.WriteLine("-----------------");
            Console.WriteLine("Узнать, является ли заданный текст палиндромом");
            Console.WriteLine("Введите текст:");
            string pal = Console.ReadLine();
            string PAL = "";
            for (int c = pal.Length - 1; c >= 0; c--)
            {
                PAL += pal[c];
            }
            if (pal == PAL)
                Console.WriteLine("Является палиндромом");
            else
                Console.WriteLine("Не является палиндромом");

            Console.WriteLine("-----------------");
            Console.WriteLine("Подсчитать сколько слов в строчке");
            Console.WriteLine("Введите текст:");
            string[] SlovaVStrochke;
            string strochka = Console.ReadLine();
            SlovaVStrochke = strochka.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(SlovaVStrochke.Length);

            Console.WriteLine("-----------------");
            Console.WriteLine("Чётные - нечётные");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine(text);
        }
    }
}
