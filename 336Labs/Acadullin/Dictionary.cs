using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class Dictionary
    {
        private string _name;
        private string _id;
        public void Fio(Dictionary<string, string> List)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Random rnd = new Random();
            _id = rnd.Next(100, 1000).ToString();
            List.Add(_id, name);
        }
        public void keyvalue(Dictionary<string, string> List)
        {
            foreach (var item in List)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        public void ID(Dictionary<string, string> List)
        {
            Console.WriteLine("Введите ID:");
            {
                string ID = Console.ReadLine();
                if (List.ContainsKey(ID) != true)
                {
                    Console.WriteLine("Нет такого индекса!");
                }
                foreach (var item in List)
                {
                    if (item.Key == ID)
                    {
                        Console.WriteLine("Введите новое имя:");
                        string newname = Console.ReadLine();
                        List[ID] = newname;
                        break;
                    }
                }
            }
        }
    }
}
