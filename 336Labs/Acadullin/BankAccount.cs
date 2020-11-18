using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class BankAccount
    { 
        private string _name;
        private string _surname;
        private string _id, _age;
        public delegate void SumChanged(string phonenumber);
        public delegate void RateChanged(double oldRate, double newRate);
        private static double _rate = 0.021;
        private double _paymentAccount;
        private DateTime a = new DateTime();
        private int _sum;
        private string _phonenumber;
        public delegate void Hander(string phonenumber);

        public BankAccount(string phoneNumber, int Sum)
        {
            phonenumber = phoneNumber;
            Sum = Sum;
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
        public void SetAge(DateTime newAge)
        {
            DateTime day = DateTime.Now.Date;
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
        //public static void SetFIO(BankAccount banks)
        //{
        //    Console.WriteLine("Ваша имя:");
        //    banks.SetName(Console.ReadLine());
        //    Console.WriteLine("Ваша Фамилия:");
        //    banks.SetSurname(Console.ReadLine());
        //}
        public static void SetAge(BankAccount banks)
        {
            Console.WriteLine("Ваш год рождения:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш месяц рождения:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш день рождения:");
            int d = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime();
            int year = DateTime.Now.Year;

            birthday.AddYears(y);
            birthday.AddMonths(m);
            birthday.AddDays(d);
        }
        public static void GetFIO(BankAccount banks)
        {
            Console.WriteLine($":{banks._name}");
            Console.WriteLine($":{banks._surname}");
            Console.WriteLine($":{banks._id}");
            Console.WriteLine($":{banks.A.ToString("d:m:y")}");
            Console.WriteLine($":{banks._age}");
        }
        public void Polosh(double polosh)
        {
            Console.WriteLine("Введите сколько хотите положить на счет?");
            _paymentAccount = _paymentAccount + polosh;
            Console.WriteLine("Ваш баланс:" + _paymentAccount);
        }
        public void Vzyat(double vzyat)
        {
            Console.WriteLine("Введите сколько хотите снять со счета?");
            _paymentAccount = _paymentAccount - vzyat;
            Console.WriteLine("Ваш баланс:" + _paymentAccount);
        }
       
      
        

        
    }
    
}   

    
        
  
