using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _336Labs.Bayburin
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private static int _id;
        private static double _rate = 7.7;
        private string _phoneNumber;
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetters = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetters.ToString().ToUpper() + otherLetters;
        }
        public void SetSurName(string newSurName)
        {
            newSurName = newSurName.Trim();
            var firstLetters = newSurName[0];
            var otherLetters = newSurName.Remove(0, 1);
            _surname = firstLetters.ToString().ToUpper() + otherLetters;
        }
        public void SetRate(double newRate)
        {
            _rate = newRate;
        }
        public void SetID()
        {
            Random rnd = new Random();
            int[] _id = { };
            for (int i = 0; i < 20; i++)
            {
                int temp = rnd.Next(1, 20);
                _id[i] = temp;
            }
        }
        public void GetName()
        {
            Console.WriteLine($"{_name}");
        }
        public void GetSurName()
        {
            Console.WriteLine($"{_surname}");
        }
        public void GetID()
        {
            Console.WriteLine($"{_id}");
        }
        public void GetRate()
        {
            Console.WriteLine($"{_rate}");
        }

        public void GetInfo()
        {
            Console.WriteLine($" Имя - {_name}");
            Console.WriteLine($" Фамилия - {_surname}");
            Console.WriteLine($" Уникальный id - {_id}");
            Console.WriteLine($" Процентная ставка - {_rate}");
        }
        public void Events()
        {
        }
        public string PhoneNumber { get; private set; }

        // 18.11.2020
    }
}
