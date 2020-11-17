using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _336Labs.Melenteva
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private static int _id;
        public static double _rate;
        private double _paymentAccount;
        private DateTime B = new DateTime();

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
            _SurName = firstLetter.ToString().ToUpper() + oLetters.ToString().ToLower();

        }

        public void SetId()
        {
            int a = 0;
            string ID = "";
            for (int i = 0; i < 3; i++)
            {
                ID = (char)(a % 10 + '0') + ID;
                a = a - 10;
            }
              _id = ID;

        }
        public double GetRate()
        {
            return _rate;
        }
        public void SetRate()
        {
            _rate = 5.4;
        }
        public void SetPaymentAccount(double nPaymentAccount)
        {
            _paymentAccount = nPaymentAccount;
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
