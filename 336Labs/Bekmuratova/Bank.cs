using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bekmuratova
{
    class Bank
    {
        {
        private string _name;
        private string _surname;
        private static int _id, _age;
        public static double _rate = 0.67;
        private double _paymentAccount;
        private DateTime Birth = new DateTime();
        public DateTime AccAge = DateTime.Now;

        public void SetName(string nName)
        {
            nName = nName.Trim();
            var firstLetter = nName[0];
            var oLetters = nName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + oLetters.ToString().ToLower();
        }
        public void SetSurName(string nSurName)
        {
            nSurName = nSurName.Trim();
            var firstLetter = nSurName[0];
            var oLetters = nSurName.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + oLetters.ToString().ToLower();

        }

        public void SetAge(DateTime nAge)
        {
            DateTime Birth = DateTime.Now.Date;
        }
        public double GetRate()
        {
            return _rate;
        }
        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public void SetId(string v)
        {
            Random rnd = new Random();
            _id = rnd.Next(10, 100);

        }
        public static void SetNSNIDA(BankAccount bank)
        {
            Console.WriteLine("Write your name");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Write your SurName");
            bank.SetSurName(Console.ReadLine());
        }

        public static void SetAge()
        {
            Console.WriteLine("Enter year of your birth ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth ");
            int d = Convert.ToInt32(Console.ReadLine());
            Birth = new DateTime(y, m, d);
            DateTime T = DateTime.Now;
            _age = T.Year - Birth.Year;
            Console.WriteLine();
        }

        public static bool GetNSNIDR(BankAccount bank)
        {
            if (_age < 18)
            {
                Console.WriteLine("You are too young to open an account.");
                return false;
            }
            else
            {
                Console.WriteLine($"Name:{_name}");
                Console.WriteLine($"SurName:{_surname}");
                Console.WriteLine($"ID:{_id}");
                Console.WriteLine($"Date of Birth:{Birth.ToString("d:M:y")}");
                Console.WriteLine($"age:{_age}");
                Console.WriteLine($"rate: {_rate}");
                return true;
            }
        }
        public double GetPaymentAccount()
        {
            return _paymentAccount;
        }
        public void SetSumm(double nPaymentAccount)
        {
            _paymentAccount = _paymentAccount + nPaymentAccount;
            Console.WriteLine(_paymentAccount);
        }
        public void SetMinus(double nPaymentAccount)
        {
            _paymentAccount = _paymentAccount - nPaymentAccount;
            Console.WriteLine(_paymentAccount);
        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter your name: ");
            account.SetName(Console.ReadLine());
            Console.WriteLine("Enter your Surname: ");
            account.SetSurname(Console.ReadLine());
            Console.WriteLine("Enter ID: ");
            account.SetId();
            Console.WriteLine(account.GetRate());
            Console.WriteLine("Your account: ");
            account.SetPaymentAccount(double.Parse(Console.ReadLine()));
            Console.WriteLine("How much do you put? ");
            account.SetSumm(double.Parse(Console.ReadLine()));
            Console.WriteLine(" How much do you want to rent? ");
            account.SetMinus(double.Parse(Console.ReadLine()));



        }

    }


}