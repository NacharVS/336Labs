using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class BankAccount
    {
        public delegate void SumChanged(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);
        private string _name;
        private string _surname;
        private string _id, _age;
        private double _paymentAccount = 4000;
        private static double _rate = 0.067;
        public string _phoneNumber;
        private int _sum;
        private int _accountopendate;

        public BankAccount(int sum, string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            _sum = sum;
        }

        public int opendate
        {
            get
            {
                return _accountopendate;
            }
            set
            {
                var opendate = _accountopendate;
                _accountopendate = value;
            }
        }

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
        public string GetId()
        {
            return _id;
        }
        public static void SetId(BankAccount banks)
        {
            Random rnd = new Random();
            banks._id = rnd.Next(1, 10);
        }
        public void Vnesti(double vnesti)
        {
            _paymentAccount = _paymentAccount + vnesti;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }
        public void Snytia(double snytia)
        {
            _paymentAccount = _paymentAccount - snytia;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }


        public static void SetAge(BankAccount bank)
        {
            DateTime Birthday = new DateTime();
            int NowDate = DateTime.Now.Year;
            Console.WriteLine("Ваш год рождения:");
            int уеars = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц, когда вы родились:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День вашего рождения:");
            int day = int.Parse(Console.ReadLine());

            Birthday.AddYears(уеars);
            Birthday.AddMonths(month);
            Birthday.AddDays(day);

            Console.WriteLine("Сколько лет: ");
            Console.WriteLine(NowDate - уеars);

        }
        public static void GetFIOandinformation(BankAccount bank)
        {
            Console.WriteLine($":{bank._name}");
            Console.WriteLine($":{bank._surname}");
            Console.WriteLine($":{bank._id}");
            Console.WriteLine($":{bank.Birthday.ToString("day:month:years")}");
            Console.WriteLine($":{bank._age}");
        }

        class ACCOUNTENENTARGS
        {
            public string Mes { get; }
            public int Sum { get; }
            public ACCOUNTENENTARGS(string message, int summa)
            {
                Mes = message;
                Sum = summa;
            }
        }
        public delegate void AccHandler(object sender, ACCOUNTENENTARGS f);
        public event AccHandler Notify;
        public double Sum { get; private set; }
        public AccHandler(int sum)
        {
            Sum = sum;
        }
        public void Receive(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new ACCOUNTENENTARGS($"На счет поступило {sum}.", sum));
        }
        public void Acted(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new ACCOUNTENENTARGS($"{sum} снята со счета.", sum));
            }
            else
            {
                Notify?.Invoke(this, new ACCOUNTENENTARGS("На вашем счету нехватает средств, sum"));
            }
        }

        TestList.Add("newName");
        TestList.Add("newName");
        T.Add("newName");
       }
    
}



