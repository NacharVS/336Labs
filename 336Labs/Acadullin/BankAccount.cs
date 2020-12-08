using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id, _age;
        public delegate void SumChanged(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);
        private static double _rate = 0.021;
        private double _paymentAccount = 1000;
        private DateTime a = new DateTime();
        private int _sum;
        private string _phonenumber;
        public delegate void Hander(string phonenumber);
        public int _accountDateOpen;

        public string Message { get; }
        public int Dum { get; }
        public BankAccount(string messag, int sum)
        {
            Message = messag;
            Sum = Sum;
        }
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                var oldRate = _rate;
                _rate = Rate;
                RateChangedEvent?.Invoke(oldRate, _rate);
            }
        }
        public int DateOpen
        {
            get
            {
                return _accountDateOpen;
            }
            set
            {
                var DateOpen = _accountDateOpen;
                _accountDateOpen = value;
            }
        }
        public delegate void AccounHandler(object a, BankAccount b);
        public event BankAccount Notify;
        public int Sum { get; private set; }
        public BankAccount(int sum)
        {
            Sum = sum;
        }
        public void Lay(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new BankAccount($"На ваш счет поступило{sum}", sum));
        }
        public void Remove(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new BankAccount($"С вашего счета снято {sum}", sum));
            }
            else
            {
                Notify?.Invoke(this, new BankAccount($"Недостаточно денег на вашем счете", sum));
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
        public void SetAge(DateTime newAge)
        {
            DateTime day = DateTime.Now.Date;
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
        public void SetId(BankAccount banks)
        {
            int a = 0;
            string Id = "";
            for (int i = 0; i < 3; i++)
            {
                Id = (char)(a % 10 + '0') + Id;
                a = a / 10;
            }
            _id = Id;
        }
        //public static void SetFIO(BankAccount banks)
        //{
        //    Console.WriteLine("Ваша имя:");
        //    banks.SetName(Console.ReadLine());
        //    Console.WriteLine("Ваша Фамилия:");
        //    banks.SetSurname(Console.ReadLine());
        //}
        public static void SetAge(BankAccount banks)
        {
            Console.WriteLine("Ваш год рождения:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш месяц рождения:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш день рождения:");
            int d = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime();
            int newyear = DateTime.Now.Year;

            birthday.AddYears(y);
            birthday.AddMonths(m);
            birthday.AddDays(d);

            Console.WriteLine("Вам сейчас:");
            Console.WriteLine(newyear - y);
        }
        public static void GetFIO(BankAccount banks)
        {
            Console.WriteLine($":{banks._name}");
            Console.WriteLine($":{banks._surname}");
            Console.WriteLine($":{banks._id}");
            Console.WriteLine($":{banks.A.ToString("d:m:y")}");
            Console.WriteLine($":{banks._age}");
        }
        public void Polosh(double polosh)
        {
            Console.WriteLine("Введите сколько хотите положить на счет?");
            _paymentAccount = _paymentAccount + polosh;
            Console.WriteLine("Ваш баланс:" + _paymentAccount);
        }
        public void Vzyat(double vzyat)
        {
            Console.WriteLine("Введите сколько хотите снять со счета?");
            _paymentAccount = _paymentAccount - vzyat;
            Console.WriteLine("Ваш баланс:" + _paymentAccount);
        }
        public event RateChanged RateChangedEvent;
        public string PhoneNumber
        {
            get
            {
                return _phonenumber;
            }
            private set
            {
                _phonenumber = value;
            }
        }
        public AddRange();
        {
        Testlist.Add("newName")    
        }
    }
}
          
            
            
     





