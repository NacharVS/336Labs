using _336Labs.Ippolitova;
using System;
using System.Collections.Generic;

namespace _336Labs
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
    class Program
    {
        static void Main (string[] args)
        {
            void InFo(string name, int age, string surname, string id  )
            {
                List<BankAccount> AccLis = new List<BankAccount>();
                AccLis.Add(new BankAccount("12321dfd", "Юля", "Ипполитова", 18));
                AccLis.Add(new BankAccount("12321dd", "Insaf", "Sabirov", 18));
                AccLis.Add(new BankAccount("12dfd", "Юля", "Gilfanova", 18));
                AccLis.Add(new BankAccount("12321dfd", "Юля", "kirillina", 18));
                AccLis.Add(new BankAccount("12321dfd", "Юля", "politr", 18));

                foreach (var item in AccLis )
                {
                    Console.WriteLine(item._surname );
                    Console.WriteLine(item._age );
                }

                foreach (BankAccount item in AccLis)
                {
                    if (item._age == 15)
                    {

                    }
                }
            }
        }
    }
}
