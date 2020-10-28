using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.021;
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
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public double GetRate()
        {
            return _rate;
        }
        public void SetRate(double rate)
        {
            _rate = rate;
        }
        public void Polosh(double polosh)
        {
            _paymentAccount = _paymentAccount + polosh;
        }
        public void Vzyat(double vzyat)
        {
            _paymentAccount = _paymentAccount + vzyat;
        }
        private void People(object sender, RoutedEventArgs e)
        {
            //int a =

            //var date = DateTime.ParseExact(a, "dd.MM.yyyy");
            //var age = DateTime.Now.Year - date.Year;
            DateTime dateBirthday = new DateTime(2002, 4, 25);



        }
    }
} 
    
        
  
