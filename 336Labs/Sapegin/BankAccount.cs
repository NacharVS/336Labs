using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sapegin
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 6.7;
        private double _paymentAccount;
        private int _age;

        public void SetName(string newName)
        {

            newName = newName.Trim();
            var firstletter = newName[0];
            var otherletter = newName.Remove(0, 1);
            _name = firstletter.ToString().ToUpper() + otherletter;

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

            for (int i =0;  i < 3; i++ )
            {
                str = (char)(k % 10) + str;
                k = k / 10;
            }
            _id = str;
       
        }
        public void SetPaymentAccount()
        {
            
        }

        public void SetAge(double age)
        {
            double BirthDate = double.Parse(Console.ReadLine());
            DateTime nowDate = DateTime.Today;
            double age = nowDate.Year - BirthDate;
        }
       
    }
}
    
