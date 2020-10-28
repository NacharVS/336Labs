using System;
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
        private static double _rate = 0.67;
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
            Console.WriteLine();
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
        // Операции
        public void Deposit()
        {
            Console.Write("Сколько хотите внести >>> ");

            double depos = Convert.ToDouble(Console.ReadLine());

            _paymentAccount = _paymentAccount + depos;

            Console.Write("На вашем счету стало " + _paymentAccount);
        }

        public void Withdraw()
        {
            Console.Write("Сколько хотите снять  >>> ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;
            Console.Write("На вашем счету осталось : " + _paymentAccount);
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
            if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
            {
                int n = 0;
                while (n == 0)
                {
                    Console.WriteLine();
                    bank.Deposit();
                    Console.WriteLine();
                    bank.Withdraw();
                }
            }
        }
    }
}