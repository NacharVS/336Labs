using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private int _id;
        private DateTime _age;
        public static double _rate = 0.067;
        private double _paymentAccount;


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
        public void SetId()
        {
            Random rnd = new Random();
            _id = rnd.Next(10, 100);
        }
        public static void SetNameSurnameIdAge(BankAccount bank)
        {
            Console.WriteLine("Введите имя");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию");
            bank.SetSurname(Console.ReadLine());
            bank.SetId();
            Console.WriteLine("Введите дату рождения");
            bank.SetAge(Console.ReadLine());
        }

        //Выдача
        public static void GetNameSurnameId(BankAccount bank)
        {
            Console.WriteLine($"Имя:     {bank._name}");
            Console.WriteLine($"Фамилия: {bank._surname}");
            Console.WriteLine($"ID:      {bank._id}");
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
            BankAccount.GetNameSurnameId(bank);
            int n = 1;
            while (n >0)
            {
                BankAccount.GetNameSurnameId(bank);
                bank.Deposit();
                bank.Withdraw();
            }
        }
    }
}
