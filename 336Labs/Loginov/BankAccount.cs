using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private int _id, _age;
        public static double _rate = 0.067;
        private double _paymentAccount;
        private DateTime DayOfBirth = new DateTime();


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

        public void SetAge(DateTime newAge)
        {
            DateTime dayofbirth = DateTime.Now.Date;
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
            Console.WriteLine(bank.DayOfBirth);
            DateTime Today = DateTime.Now;
            Console.WriteLine(Today);
            bank._age = Today.Year - bank.DayOfBirth.Year;
            Console.WriteLine(bank._age);
        }


        //Выдача
        public static void GetNameSurnameId(BankAccount bank)
        {
            Console.WriteLine($"Имя:     {bank._name}");
            Console.WriteLine($"Фамилия: {bank._surname}");
            Console.WriteLine($"ID:      {bank._id}");
            Console.WriteLine($"Дата рождения: {bank.DayOfBirth.ToString("dd:MM:yyyy")}");
            Console.WriteLine($"Возраст: {bank._age}");
        }
        // Операции
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
    }

    class BA
    {

        public static void BnkAc()
        {
            BankAccount bank = new BankAccount();
            BankAccount.SetNameSurnameIdAge(bank);
            BankAccount.SetId(bank);
            BankAccount.SetAge(bank);
            BankAccount.GetNameSurnameId(bank);
            int n = 1;
            while (n >0)
            {
                bank.Deposit();
                bank.Withdraw();
            }
        }
    }
}
