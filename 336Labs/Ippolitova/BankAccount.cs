using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private double _paymentAccount = 2000;
        private double _age;
        private DateTime DayOfBirth = new DateTime();

        
        DateTime dayofbirth = DateTime.Now.Date;
    

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

        public static void GetNameSurnameId(BankAccount bank)
        {
            Console.WriteLine($"Имя:     {bank._name}");
            Console.WriteLine($"Фамилия: {bank._surname}");
            Console.WriteLine($"ID:      {bank._id}");
            Console.WriteLine($"Дата рождения: {bank.DayOfBirth.ToString("dd:MM:yyyy")}");
            Console.WriteLine($"Возраст: {bank._age}");
        }

    }
}
