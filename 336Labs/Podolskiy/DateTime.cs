﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class BankAccount
    {

        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.021;
        private double _paymentAccount = 12000;


        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetter;
        }
        public void Deposit()
        {
            Console.WriteLine("Сколько хотите внести >>> ");

            double depos = Convert.ToDouble(Console.ReadLine());

            _paymentAccount = _paymentAccount + depos;

            Console.WriteLine("На вашем счету стало " + _paymentAccount);
        }

        public void Withdraw()
        {
            Console.WriteLine("Сколько хотите снять  >>> ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;

            Console.WriteLine("На вашем счету осталось : " + _paymentAccount);
        }
        public  void MethodDate()
        {
            Console.WriteLine("Введите ваш год рождения");
            int  years = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц, когда вы родились");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день, когда вы родились");
            int days = int.Parse(Console.ReadLine());

            DateTime dayOfBirth = new DateTime(2002 , 4, 4 );
  
            dayOfBirth.AddYears(years);
            dayOfBirth.AddMonths(month );
            dayOfBirth.AddDays(days );

            Console.WriteLine( $"Год: {years} Месяц:{month} День:{days}");
            

        }
       
    }

}