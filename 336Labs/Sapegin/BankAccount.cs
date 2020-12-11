using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sapegin
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 6.7;
        private double _paymentAccount = 0;
        private int _age;

        public string Name => _name;
        public string Surname => _surname;
        public int Age => _age;

        public BankAccount(string Name, string Surname, int Age)
        {

            _name = Name;
            _surname = Surname;
            _age = Age;

        }

        public double GetRate()
        {
            return _rate;
        }

        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public string GetId()
        {
            return _id;
        }
        public void SetId()
        {
            int k = 0;
            string str = "";

            for (int i =0;  i < 3; i++ )
            {
                str = (char)(k % 10 + '0' ) + str;
                k = k / 10;
            }
            _id = str;
       
        }

        public void PaymentAccount(double S)
        {
            _paymentAccount = S;
        }
       
        public double GetPaymentAccount()
        {
            return _paymentAccount;
        }

        public void AddSum(double S)
        {
            _paymentAccount = _paymentAccount + S;
            Console.WriteLine(_paymentAccount);
        }

        public void AddDiff(double S)
        {
            _paymentAccount = _paymentAccount - S;
            Console.WriteLine(_paymentAccount);
        }

        //public void DateAge()
        //{
        //    DateTime BirthDate = new DateTime();
        //    int NowYear = DateTime.Now.Year;
        //    Console.WriteLine("Введите дату своего рождения(дд/мм/гг): ");
        //    int d = int.Parse(Console.ReadLine());
        //    int m = int.Parse(Console.ReadLine());
        //    int y = int.Parse(Console.ReadLine());
        //    BirthDate.AddYears(y);
        //    BirthDate.AddMonths(m);
        //    BirthDate.AddDays(d);
        //    Console.WriteLine("Возраст клиента: ");
        //    Console.WriteLine(NowYear - y);
        //}

       
       
    }


}


//Тo что в классе Program
//BankAccount account = new BankAccount();
//Console.WriteLine("Ваше имя: ");
//account.SetName(Console.ReadLine());
//Console.WriteLine("Ваша фамилия: ");
//account.SetSurname(Console.ReadLine());
//Console.WriteLine("Ставка: ", account.GetRate());
//Console.WriteLine("Ваш ID: ");
//account.SetId();
//Console.WriteLine(account.GetId());
//account.Age();
//Console.WriteLine("Ваш счёт");
//account.PaymentAccount(double.Parse(Console.ReadLine()));
//Console.WriteLine("Пополнить счёт: ");
//account.AddSum(double.Parse(Console.ReadLine()));
//Console.WriteLine("Снять со счёта: ");
//account.AddDiff(double.Parse(Console.ReadLine()));

