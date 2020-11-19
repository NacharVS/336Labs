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
        private int _sum;
        
        public BankAccount(int sum, string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            _sum = sum;
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
        public string GetId()
        {
            return _id;
        }
        public void SetId(BankAccount banks)
        {
            int a = 0;
            string Id = "";
            for (int i = 0; i < 3; i++)
            {
                Id = (char)(a % 10 + '0') + Id;
                a = a / 10;
            }
            _id = Id;
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

        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                _phoneNumberEvent?.Invoke(_phoneNumber);

            }
        }
        


        public static void SetAge(BankAccount bank)
        {
            DateTime Birthday = new DateTime();
            int NowDate = DateTime.Now.Year;
            Console.WriteLine("Ваш год рождения:");
            int уеars = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц, когда вы родились:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("День вашего рождения:");
            int day = int.Parse(Console.ReadLine());
           
            Birthday.AddYears(уеars);
            Birthday.AddMonths(month);
            Birthday.AddDays(day);

            Console.WriteLine("Сколько лет: ");
            Console.WriteLine(NowDate - уеars);

        }
        //public static void SetId(BankAccount bank)
        //{
        //    Random rnd = new Random();
        //    bank._id = rnd.Next(0, 20);

        //}




        public delegate void Handler(string phoneNumber);     
           
            
           
        


    }

}

