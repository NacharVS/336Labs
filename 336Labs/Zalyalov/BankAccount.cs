using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Zalyalov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        public static double _rate = 0.067;
        private double _paymentAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters
        }
    }
}
