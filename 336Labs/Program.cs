using _336Labs.Yusupov;
using Interfaces;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void main(string[] args)
        {
            void InFo(string name, int age, string surname, string id)
            {
                List<BankAccount> AccLis = new List<BankAccount>();
                AccLis.Add(new BankAccount("12321dfd", "Юля", "Ипполитова", 18));

                foreach (var item in AccLis)
                {
                    Console.WriteLine(item._surname);
                    Console.WriteLine(item._age);
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
