using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class BankAccount
    {
        private string _name;
        private string _SURNAME;
        private string _id;
        private static double _rate;
        private double _paymentAccount;

        public void list (string sur, string nam)
        {
            nam = nam.Trim();
            var oneLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = oneLet.ToString().ToUpper() + lastLet;

            sur = sur.Trim();
            var oneLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _SURNAME = oneLet1.ToString().ToUpper() + lastLet1;

        }
            public void SetName(string newName)
              {
            ллллд
              }
    }
}
