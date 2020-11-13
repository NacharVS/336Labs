using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class BankAccount
    {
        private string _name; 
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
        public delegate void Handler(string phonenumber);
        private int _sum;
        private string _phoneNumber;
        public BankAccount(int sum, string phoneNumber)
        {
            _sum = sum;
            _phoneNumber = phoneNumber;
        }
        
    class Account
        {
        
        public delegate void AccountHandler(object sender, AccountEventArgs e);
            public event AccountHandler Notify;
            public Account(int sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   
            }
       
        public int Sum { get; private set; }
            public void Put(int sum)
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
                Sum += sum;
                Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
            }
        }
    }

    public void Take(int sum)
    {
        Console.Write("Сколько хотите внести >>> ");
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

      class BA
      {
     
        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
        private static void DisplayRedMessage(String message)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            
            Console.ResetColor();
        }

        public static void BnkAc()

        {
            BankAccount bank = new BankAccount();
            BankAccount.SetNameSurnameIdAge(bank);
            BankAccount.SetId(bank);
            BankAccount.SetAge(bank);
            if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
            {

                BankAccount bank = new BankAccount();
                BankAccount.SetNameSurnameIdAge(bank);
                BankAccount.SetId(bank);
                BankAccount.SetAge(bank);
                if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
                {
                    /*  int n = 0;
                      while (n == 0)
                      {
                          Console.WriteLine();
                          bank.Deposit();
                          Console.WriteLine();
                          bank.Withdraw();
                      }*/

                    Account acc = new Account(100);
                    acc.Put(20);    // добавляем на счет 20
                    Console.WriteLine($"Сумма на счете: {acc.Sum}");
                    acc.Take(70);   // пытаемся снять со счета 70
                    Console.WriteLine($"Сумма на счете: {acc.Sum}");
                    acc.Take(180);  // пытаемся снять со счета 180
                    Console.WriteLine($"Сумма на счете: {acc.Sum}");
                    Console.Read();
                }
                Account acc = new Account(100);
                acc.Notify += DisplayMessage;
                acc.Put(20);
                acc.Take(70);
                acc.Take(150);
                Console.Read();
            }
        
      }
    }
}

      
    

 