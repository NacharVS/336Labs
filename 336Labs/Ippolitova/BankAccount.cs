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
        public static double _rate = 0.0067;
        private double _paymentAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }

        public void Deposit (double deposit)
        {
            Console.WriteLine("Какую сумму вы намерены внести? :");
            deposit = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount + deposit;
            Console.WriteLine("На вашем счету:" + _paymentAccount + "рублей");
        }

        public void Withdraw (double withdraw)
        {
            Console.WriteLine("Какую сумму вы намерены снять? :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;
            Console.WriteLine("На вашем счету:" + _paymentAccount + "рублей");
        }

        static void main (string [] args)
        {

        }
    }
}
