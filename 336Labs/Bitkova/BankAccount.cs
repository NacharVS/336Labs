using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace _336Labs.Bitkova
{
    
    class BankAccount
    {
        
        

        public delegate void Number(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);

        private string _name;
        private string _surname;
        private int _id;
        private static double _rate = 0.035;
        private int _sum;
        private string _phoneNumber;
        private int _age;

        public string Name => _name;
        public string Surname => _surname;
        public int Age => _age;
        public int ID => _id;

        

        public BankAccount(string Name, string Surname, int Age, int ID)
        {
            _name = Name;
            _surname = Surname;
            _age = Age;
            _id = ID;
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
                _rate = value;
                RateChangedEvent?.Invoke(oldRate, _rate);
            }
        }

        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                PhoneNumberEvent?.Invoke(PhoneNumber);
            }
        }

        public void Deposit(int sum)
        {
            Sum += sum;
        }

        public void Widthraw(int sum)
        {
            Sum -= sum;
        }
       
        public event Number PhoneNumberEvent;
        public event RateChanged RateChangedEvent;
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public void newRate(double newRate)
        {
            _rate = newRate;
        }

        public void Date()
        {
            Console.WriteLine("Дата регистрации");
            Console.WriteLine(DateTime.Now);

        }
        //public void Age()
        //{
        //    DateTime BirthDate = new DateTime();
        //    int NowDate = DateTime.Now.Year;
        //    Console.WriteLine("Введите день: ");
        //    int day = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите месяц: ");
        //    int month = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите год: ");
        //    int year = int.Parse(Console.ReadLine());
        //    BirthDate.AddYears(year);
        //    BirthDate.AddMonths(month);
        //    BirthDate.AddDays(day);
        //    Console.WriteLine("Ваш возраст: ");
        //    Console.WriteLine(NowDate - year);
        //}

        
    }
    
}


//public void SetPaymentAccount(double newPaymentAccount)
//      {
//           _paymentAccount = newPaymentAccount;
//       }

//       public double GetPaymentAccount()
//       {
//           return _paymentAccount;
//       }


//public void SetSum(double newPaymentAccount)
//{
//    _paymentAccount = _paymentAccount + newPaymentAccount;
//    Notify?.Invoke(PhoneNumber);
//    Console.WriteLine(_paymentAccount);
//}

//public void SetMinus(double newPaymentAccount)
//{
//    _paymentAccount = _paymentAccount - newPaymentAccount;
//    Notify?.Invoke(PhoneNumber);
//    Console.WriteLine(_paymentAccount);
//}
