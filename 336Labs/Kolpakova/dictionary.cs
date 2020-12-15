using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class dictionary
    {
        static void Main(string[] args)
        {
            int id = 0;
            Dictionary<int, string> list = new Dictionary<int, string>();
            Console.WriteLine("Напишите имя");
            while (id < 6)
            {
                id++;
                list.Add(id, Console.ReadLine());


            }
            foreach (var item in list)
            {
                Console.Write(item.Key + "");
                Console.WriteLine(item.Value);
            }
            while (id <= 6)
            {
                Console.WriteLine("Для того чтобы изменить имя введите id, имя которого нужно заменить");
                id = Convert.ToInt32(Console.ReadLine());
                list[id] = Console.ReadLine();
                Console.WriteLine("все имена");
                foreach (var item in list)

                {
                    Console.Write(item.Key + "");
                    Console.WriteLine(item.Value);

                }


            }
        }
    }
}
