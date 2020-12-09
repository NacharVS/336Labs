﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class BankAccount
    {
        //Переменные
        private string _name;
        private string _surname;
        private int _id, _age;
        public static double _rate = 0.67;
        //private double _paymentAccount;
        private DateTime DayOfBirth = new DateTime();
        public DateTime AccAge = DateTime.Now;

        //Установка

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters.ToString().ToLower();
        }

        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters.ToString().ToLower();
        }

        public static void SetId(BankAccount bank)
        {
            Random rnd = new Random();
            bank._id = rnd.Next(10, 100);
        }

        public static void SetNameSurnameIdAge(BankAccount bank)
        {
            Console.WriteLine("Введите имя");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию");
            bank.SetSurname(Console.ReadLine());
        }

        public static void SetAge(BankAccount bank)
        {
            Console.WriteLine("Введите год рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день рождения");
            int day = Convert.ToInt32(Console.ReadLine());
            bank.DayOfBirth = new DateTime(year, month, day);
            DateTime Today = DateTime.Now;
            bank._age = Today.Year - bank.DayOfBirth.Year;

            /*            Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(Today);
                        Console.WriteLine(Today.AddSeconds(10));
                        Console.WriteLine();
                        Console.WriteLine();*/
        }

        //Выдача
        public static bool GetNameSurnameIdAgeRate(BankAccount bank)
        {
            if (bank._age < 14)
            {
                Console.WriteLine("Вы не можете завести счет в банке");
                return false;
            }
            else
            {
                Console.WriteLine($"Имя:     {bank._name}");
                Console.WriteLine($"Фамилия: {bank._surname}");
                Console.WriteLine($"ID:      {bank._id}");
                Console.WriteLine($"Дата рождения: {bank.DayOfBirth.ToString("dd:MM:yyyy")}");
                Console.WriteLine($"Возраст: {bank._age}");
                Console.WriteLine($"Ставка: {_rate}");
                return true;
            }
        }
    }
    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
    class Account
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;
        public double Sum { get; private set; }
        public Account(int sum)
        {
            Sum = sum;
        }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
            }
        }

        public static void SetAccAge(BankAccount bank)
        {
            bank.AccAge = DateTime.Now;
            Console.WriteLine($"{bank.AccAge} - дата создания ");
        }
        public void Rate(BankAccount bank)
        {
            double _rate = 0.03;
            double Wheel = 0;
            Wheel = Sum;
            DateTime Today = DateTime.Now;
            TimeSpan Age = Today.Subtract(bank.AccAge);
            int secs = (int)Age.TotalSeconds;
            Console.WriteLine($"Прошло - {Age} секунд");
            while (secs >= 5)
            {
                secs = secs - 5;
                Sum = Sum + (Sum * _rate);
            }
            Console.WriteLine($"Ваш вклад равен - {Sum} рублей");
            Sum = Wheel;
        }

    }

    class BA
    {

        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }

        public static void BnkAc()
        {
            BankAccount bank = new BankAccount();
            BankAccount.SetNameSurnameIdAge(bank);
            Account.SetAccAge(bank);
            BankAccount.SetId(bank);
            BankAccount.SetAge(bank);
            if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
            {
                Account acc = new Account(10);
                acc.Notify += DisplayMessage;
                acc.Put(120);
                acc.Take(70);
                acc.Take(150);
                int n = 0;
                while (n == 0)
                {
                    Console.WriteLine("Посчитать вклад?");
                    Console.ReadLine();
                    acc.Rate(bank);
                }
            }
        }
        public static void Bonk()
        {
            List<BonkAccount> BankAccountList = new List<BonkAccount>(3);
            BankAccountList.Add(new BonkAccount("Biba", 15));
        }
    }
    class BonkAccount
    {
        public string Name;
        public int Age;


        public static void MM(BonkAccount BankAccountList)
        {
            //Console.WriteLine(Name);
        }
    }
}
