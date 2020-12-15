using System;
using System.Collections;
using System.Collections.Generic;

namespace _336Labs.Bitkova
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> hi = new Dictionary<string, string>();
            Console.WriteLine("---Введите имя---");
            string Name = Console.ReadLine().ToString();
            
            Random rnd = new Random();
            string ID = rnd.Next(60, 65).ToString();
            hi.Add(ID, Name);

            foreach (var it in hi)
            {
                Console.WriteLine("---Ваши данные---");
                Console.WriteLine($"Id - {it.Key}, Name - {it.Value}");
            }

            Console.WriteLine("---Ваш ID---");
            ID = Console.ReadLine().ToString();

            foreach (var item in hi)
            {
                if (item.Key == ID)
                {
                    Console.WriteLine("---Введите имя---");
                    string newName = Console.ReadLine();
                    hi[item.Value] = newName;
                    Console.WriteLine($"id - {item.Key}, Name - {item.Value}");
                    break;
                }
            } 
        }
    }
}


//    BankAccount account = new BankAccount("+79003279046", 5000);
//    Console.WriteLine("Введите имя: ");
//    account.SetName(Console.ReadLine());
//    Console.WriteLine("Введите фамилию: ");
//    account.SetSurname(Console.ReadLine());
//    account.Date();
//    Console.WriteLine("Ваш ID: ");
//    account.SetId();
//    Console.WriteLine(account.GetID());
//    account.RateChangedEvent += RateMessage;
//    Console.WriteLine($"Ваша ставка: {account.Rate}");
//    account.newRate(0.47);
//    Console.WriteLine($"Ваша ставка: {account.Rate}");
//    Console.WriteLine("Введите свой день рождения.");
//    account.Age();
//    Console.WriteLine($"Ваш счет: {account.Sum}");
//    account.PhoneNumberEvent += MessageSetting;
//    Console.WriteLine("Сколько хотите закинуть?");
//    account.Deposit(int.Parse(Console.ReadLine()));
//    Console.WriteLine($"Ваш счет: {account.Sum}");
//    Console.WriteLine("Сколько хотите снять?");
//    account.Widthraw(int.Parse(Console.ReadLine()));
//    Console.WriteLine($"Ваш счет: {account.Sum}");
//    Console.WriteLine("Вы взяли кредит, случайно)))");

//}

//public static void MessageSetting(string phoneNumber)
//{
//    Console.WriteLine($"Message send at {phoneNumber}");
//}
//public static void RateMessage(double oldRate, double newRate)
//{
//    Console.WriteLine($"Old rate {oldRate} changed to {newRate}");

//___________________________

//Console.WriteLine("Здание");
//IBuilding buildobject;
//buildobject = new Building();
//buildobject.Stand();

//Console.WriteLine("--------------------");

//Console.WriteLine("Крестьянин");
//IPeasant peasantobject;
//peasantobject = new Peasant();
//peasantobject.Health = 100;
//peasantobject.PeasantHealth();
//peasantobject.Work();

//Console.WriteLine("--------------------");

//Console.WriteLine("Воин");
//ISoldier soldierobject;
//soldierobject = new Soldier();
//soldierobject.Health = 100;
//soldierobject.SoldierHealth();
//soldierobject.Work();

//Console.WriteLine("--------------------");