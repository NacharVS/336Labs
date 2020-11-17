using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class BankAccount
    {
        public delegate void Number(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.035;
        private int _sum;
        private string _phoneNumber;

        public BankAccount(string phoneNumber, int sum)
        {
            PhoneNumber = phoneNumber;
            Sum = sum;
        }

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstletter = newName[0];
            var otherletters = newName.Remove(0, 1);
            _name = firstletter.ToString().ToUpper() + otherletters;
        }

        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters;

        }
        
        public string GetID()
        {
            return _id;
        }

        public void SetId()
        {
            int a = 0;
            string ID = "";
            for (int i = 0; i < 3; i++)
            {
                ID = (char)(a % 10 + '0') + ID;
                a = a / 10;
            }
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
        public void Age()
        {
            DateTime BirthDate = new DateTime();
            int NowDate = DateTime.Now.Year;
            Console.WriteLine("Введите день: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            BirthDate.AddYears(year);
            BirthDate.AddMonths(month);
            BirthDate.AddDays(day);
            Console.WriteLine("Ваш возраст: ");
            Console.WriteLine(NowDate - year);
        }
         
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
