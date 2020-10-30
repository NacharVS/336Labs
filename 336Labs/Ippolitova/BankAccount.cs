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
        public static double _rate = 0.067;
        private DateTime DayOfBirth = new DateTime();
        
        
        DateTime dayofbirth = DateTime.Now.Date;
       
    public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetter;
            Console.WriteLine(_name);

                   
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


        public void MethodDates()
        {
            DateTime dayOfBirthday = new DateTime();
            int toYear = DateTime.Now.Year;

            Console.WriteLine("Введите год:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int days = int.Parse(Console.ReadLine());

            dayOfBirthday.AddYears(years);
            dayOfBirthday.AddMonths(month);
            dayOfBirthday.AddDays(days);

            Console.WriteLine("Вам сейчас: ");
            Console.WriteLine(toYear - years);
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
 