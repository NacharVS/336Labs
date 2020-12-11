using _336Labs.Sapegin;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {

            //BankAccount account = new BankAccount();
            //Console.WriteLine("Введите имя: ");
            //account.SetName(Console.ReadLine());
            //Console.WriteLine("Введите Фамилию: ");
            //account.SetSurname(Console.ReadLine());
            //Console.WriteLine("Ваша ставка", account.GetRate());
            //Console.WriteLine("Ваш ID: ");
            //account.SetId();
            //Console.WriteLine(account.GetId());
            //Console.WriteLine("Ваш счёт: ");
            //account.AddSum(double.Parse(Console.ReadLine()));
            ////Console.WriteLine("Введите месяц рождения: "); 
            ////double Birth = double.Parse(Console.ReadLine());
            ////Console.WriteLine("Введите день рождения: ");
            ////double Birtha = double.Parse(Console.ReadLine());
            ////Console.WriteLine("Введите год рождения: ");
            ////double Birthb = double.Parse(Console.ReadLine());

            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("Vasya", "Pupkin", 12));
            accounts.Add(new BankAccount("Andrey", "Sapegin", 18));
            accounts.Add(new BankAccount("Tanya", "Bitkova", 103));

            Edit(accounts, "Dima", "Bitkov", 103);


            foreach(var item in accounts)
            {
                Console.WriteLine($"{item.Name} {item.Surname}, {item.Age} y.o");
            }

        }
        static void Edit(string newName, string newSurname, string newAge)
        {
            if ()
            {

            }
        }

    }
}
