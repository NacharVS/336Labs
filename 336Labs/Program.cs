using System;
using System.Collections;
using System.Collections.Generic;

namespace _336Labs.Bitkova
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Vasya", "Pupkin", 12, 0001));
            accounts.Add(new BankAccount("Andrey", "Sapegin", 18, 0002));
            accounts.Add(new BankAccount("Tanya", "Bitkova", 103, 0003));

            //Edit("Dima", "Bitkov", 103, 0003, accounts);

            foreach (var item in accounts)
            {
                Console.WriteLine($"{item.Name} {item.Surname}, {item.Age} y.o, ID:{item.ID}");
            }

            Console.WriteLine("------------------------------");

            for(int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].ID == 0003)
                {
                   
                }
            }

            //static void Edit(string newName, string newSurname, int newAge, int searchID, List<BankAccount> accounts)
            //{
            //    foreach (BankAccount item in accounts)
            //    {
            //        if (item.ID == 0003)
            //        {
            //            Console.WriteLine($"{newName} {newSurname}, {newAge} y.o, ID:{searchID}");
            //        }
            //    }
            //}


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