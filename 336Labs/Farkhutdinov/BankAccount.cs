﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _336Labs.Farkhutdinov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private static string _datebirth;
        private static int _age;
        private static int _id;
        private static double _rate = 0.55;
        private static double _balance;
        private static string _phoneNumber;
        public delegate void Handler(string phoneNumber);
        public event Handler Notify;
        public delegate void RateChanged(double oldRate, double newRate);
        public event RateChanged RateChangedEvent;
        private DateTime _accountOpenDate;
        public BankAccount(double balance, string phoneNumber)  
        {
            _balance = balance;
            _phoneNumber = phoneNumber;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }
        public void SetBalance(double balance)
        {
            _balance = balance;
        }
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetters = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetters.ToString().ToUpper() + otherLetters;
        }
        public void SetSurName(string newSurName)
        {
            newSurName = newSurName.Trim();
            var firstLetters = newSurName[0];
            var otherLetters = newSurName.Remove(0, 1);
            _surname = firstLetters.ToString().ToUpper() + otherLetters;
        }
        public void SetDateBirth(int day, int month, int year)
        {
            _datebirth = ($"{day}.{month}.{year}");
            if (DateTime.Now.Month >= month && DateTime.Now.Day >= day)
            { _age = DateTime.Now.Year - year; }
            else _age = DateTime.Now.Year - year - 1;
        }
        public void SetID()
        {
            Random rnd = new Random();
            _id = rnd.Next(1, 1000000);
            // будет доработано, а пока так. Шанс выпадения идентичного id = 1/1000000
        }
        public void GetInfo()
        {
            Console.WriteLine($" Имя - {_name}");
            Console.WriteLine($" Фамилия - {_surname}");
            Console.WriteLine($" Дата рождения - { _datebirth}");
            Console.WriteLine($" Ваш возраст - { _age}");
            Console.WriteLine($" Уникальный id - {_id}");
            Console.WriteLine($" Процентная ставка - {_rate}");
        }
        public void SetBalanceRep(double balance)
        {
            Balance += balance;
        }
        public void SetBalanceRem(double balance)
        {
            Balance -= balance;
        }
        public void SetRate(double newRate)
        {
            Rate = newRate;
        }
        public string PhoneNumber { get; private set; }
        public double Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
                Notify?.Invoke(_phoneNumber);
            }
        }
        public double Rate
        {
            get
            {
                return _rate;
            }
            private set
            {
                var oldRate = _rate;
                _rate = value;
                RateChangedEvent?.Invoke(oldRate, _rate);
            }
        }
    }
}
