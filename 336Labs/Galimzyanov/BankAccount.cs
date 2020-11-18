using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class BankAccount
    {
        public delegate void SumChanged(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);
        private string _name;
        private string _surname;
        private string _id, _age;
        private static double _rate = 0.067;
        private double _paymentAccount = 0;
        public string _phoneNumber;
        public BankAccount(int sum, string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            Sum = sum;
        }
        
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

        public void Vnesti(double vnesti)
        {
            _paymentAccount = _paymentAccount + vnesti;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }
        public void Snytia(double snytia)
        {
            _paymentAccount = _paymentAccount - snytia;
            Console.WriteLine("Счёт" + _paymentAccount + "рублей");
        }

        public void SetAge(DateTime newAge)
        {
            DateTime d = DateTime.Now.Date;
        }
        public static void SetAge(BankAccount bank)
        {
            Console.WriteLine("Ваш год рождения:");
            int уеars = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц, когда вы родились:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День вашего рождения:");
            int day = int.Parse(Console.ReadLine());


            DateTime Birthday = new DateTime(2002, 04, 25);

            //Birthday.AddYears(years);
            Birthday.AddMonths(month);
            Birthday.AddDays(day);

            Console.WriteLine();

        }
        //public static void SetId(BankAccount bank)
        //{
        //    Random rnd = new Random();
        //    bank._id = rnd.Next(0, 20);

        //}

        
        

        public delegate void Handler(string phoneNumber)       
           
            
           
        


    }

}

