﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id, _age;
        private static double _rate = 0.067;
        private double _paymentAccount;
        

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }
        
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;

        }
        public double GetRate()
        {
            return _rate;
        }
        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public void Vnesti(double vnesti)
        {
            _paymentAccount = _paymentAccount + vnesti;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }
        public void Snytia (double snytia)
        {
            _paymentAccount = _paymentAccount - snytia;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }

        public void SetAge(DateTime newAge)
        {
            DateTime d = DateTime.Now.Date;
        }
        public static void SetAge (BankAccount bank)
        {
            Console.WriteLine("Ваш год рождения:");
            int уеars = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц, когда вы родились:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День вашего рождения:");
            int day = int.Parse(Console.ReadLine());
            DateTime F = new DateTime(years, month, day);
            Console.WriteLine(F);
            bank._age = DateTime.Now.Year - DateTime F;
            Console.WriteLine(bank._age);
            
        }
        public static void SetId(BankAccount bank)
        {
            Random rnd = new Random();
            bank._id = rnd.Next(0, 20);

        }

        abstract class Person
        {
            //public string Name { get; set }

            //public Person(string name)
            //{
            //    Name = name;
            //}

            //public void Display()
            //{
            //    Console.WriteLine(Name);
            //}
        }
        class Client : Person
        {
            //public int Sum { get; set }


        }
        class Employee : Person
        {

        }




    }

}

