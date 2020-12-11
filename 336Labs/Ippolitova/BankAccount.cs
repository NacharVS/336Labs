using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class BankAccount
    {
        private string _name;
        public string _surname;
        private string _id;
        public int _age;
        private double _paymentAccount = 2000;
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

            Console.WriteLine("На вашем счету стало:" + _paymentAccount);
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
        public int Sum { get; private set; }
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

    }
    class Rate
    {

        public void ClassRate(BankAccount bank)
        {
            DateTime Check = DateTime.Now;
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
            if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
            {
                Account acc = new Account(10);
                acc.Notify += DisplayMessage;
                acc.Put(120);
                acc.Take(70);
                acc.Take(150);
                Console.Read();
            }
        }

        public void info(int i);
        {
         List<BA> AccList = new List<BA>;
        
        }
}





      
    

 