using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.067;
        public static double _paymentAccount;


        public void setName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;

        }
        public void Deposit(double deposit)
        {

            _paymentAccount = _paymentAccount + deposit;
            Console.WriteLine("На вашем счету " + _paymentAccount + " рублей ");
        }
        public void Withdraw(double withdraw)
        {
            _paymentAccount = _paymentAccount - withdraw;
            Console.WriteLine("На вашем счету " + _paymentAccount + " рублей ");

        }
        static void Main(string[] args)
        {
            
            

            _paymentAccount = 100000;
            bank.Deposit(1000);
            bank.Withdraw(1500); 
            
        }
    } 
}
