using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class Dictionary
    {
        public static void D()
        {
            int id = 0;
            Dictionary<int, string> list = new Dictionary<int, string>();
            Console.WriteLine("Введите имена через Enter");
            while (id < 11)
            {
                id++;
                list.Add(id, Console.ReadLine());
            }
            foreach (var item in list)
            {
                Console.WriteLine($"id = {item.Key}, name = {item.Value} ");
            }
            while (id <= 11)
            {
                Console.WriteLine("Введите id имени которое требуется изменить");
                id = Convert.ToInt32(Console.ReadLine());
                list[id] = Console.ReadLine();
                Console.WriteLine("Новый список имен");
                foreach (var item in list)
                {
                    Console.WriteLine($"id = {item.Key}, name = {item.Value} ");
                }
            }
        }
    }
}
