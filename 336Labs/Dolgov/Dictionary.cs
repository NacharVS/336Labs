using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class Dictionary
    {
        public static void Dicti()
        {
            int id = 0;
            Dictionary<int, string> list = new Dictionary<int, string>();
            Console.WriteLine("Напишите имена по очереди");
            while (id < 10)
            {
                id++;
                list.Add(id, Console.ReadLine());
            }
            foreach (var item in list)
            {
                Console.WriteLine($"id = {item.Key}, Имя = {item.Value} ");
            }
            while (id <= 10)
            {
                Console.WriteLine("Напишите id имени которое нужно заменить");
                id = Convert.ToInt32(Console.ReadLine());
                list[id] = Console.ReadLine();
                Console.WriteLine("Список имен");
                foreach (var item in list)
                {
                    Console.WriteLine($"id = {item.Key}, Имя = {item.Value} ");
                }
            }
        }
    }
}