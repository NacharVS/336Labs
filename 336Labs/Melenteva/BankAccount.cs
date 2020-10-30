using System;
using System.Collections.Generic;
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
        public void SetName(string nName)
        {
            nName = nName.Trim();
            var firstLetter = nName[0];
            var oLetters = nName.Remove(0, 1);


        }
}
