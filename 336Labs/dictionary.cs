using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs
{
    class dictionary
    {
        public static void Main(string[] args)
        {
            int id = 0;
            Dictionary<int, string> list = new Dictionary<int, string>();
            Console.WriteLine("Write you name");
            while (id < 6)
            {
                id++;
                list.Add(id, Console.ReadLine());
            }

            foreach (var  item in list)
            {
                Console.WriteLine($"id = {item.Key}, Name = {item.Value}");
            }
            while (id <= 10)
            {
                Console.WriteLine("нвпишите id имени , которое надо заменить");
                id = Convert.ToInt32(Console.ReadLine());
                list[id] = Console.ReadLine();
                Console.WriteLine("список имен");
                foreach (var item in list)
                {
                    Console.WriteLine($"id = {item.Key}, name = {item.Value} ");
                }
            }
        }
    }
}
