using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
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
            _name = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetSurname(string newSurname)
        {

            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters;

        }

        public double GetRate()
        {
            return _rate;
        }

        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public void SetId()
        {
            int k = 0;
            string str = "";


            for (int i = 0; i < 3; i++)
            {
                str = (char)(k % 10) + str;
                k = k / 10;
            }

            _id = str;
        }
    }
}
