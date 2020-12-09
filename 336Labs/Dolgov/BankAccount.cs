using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _336Labs.Dolgov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private int _id, _age;
        public static double _rate = 0.67;
        private DateTime B = new DateTime();
        public DateTime AgeAc = DateTime.Now;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters.ToString().ToLower();
        }
        public void SetSurname(string newSurname)
        {

            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters.ToString().ToLower();

        }
        public void SetAge(DateTime newAge)
        {
            DateTime dayofbirth = DateTime.Now.Date;
        }
        public double GetRate()
        {
            return _rate;
        }

        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public static void SetId(BankAccount bank)
        {
            Random rnd = new Random();
            bank._id = rnd.Next(10, 100);
        }
        public static void SetNSNIDA(BankAccount bank)
        {
            Console.WriteLine("Напишите имя");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Напишите фамилию");
            bank.SetSurname(Console.ReadLine());
        }
        public static void SetAge(BankAccount bank)
        {
            Console.WriteLine("Год рож.");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц рож.");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День рож.");
            int D = Convert.ToInt32(Console.ReadLine());
            bank.B = new DateTime(Y, M, D);
            DateTime T = DateTime.Now;
            bank._age = T.Year - bank.B.Year;
            Console.WriteLine();
        }
        public void infor(int i)
        {
            List<Account> Aclist = new List<Account>();
            Aclist.Add(new Account("Bulka", "Bulkesh"));
            Aclist.Add(new Account("Bulka", "Bulkesh"));
            Aclist.Add(new Account("Bulka", "Bulkesh"));
            Aclist.Add(new Account("Bulka", "Bulkesh"));
            Aclist.Add(new Account("Bulka", "Bulkesh"));

            foreach (var i in Aclist)
            {
                Console.WriteLine(_name + " " + _surname);
                Console.WriteLine();
            }
        }
        public static bool GetNSNIDR(BankAccount bank)
        {
            if (bank._age < 16)
            {
                Console.WriteLine("Ваш возраст слишком мал для заведения счета.");
                return false;
            }
            else
            {
                Console.WriteLine($"Имя:{bank._name}");
                Console.WriteLine($"Фамилия:{bank._surname}");
                Console.WriteLine($"ID:{bank._id}");
                Console.WriteLine($"Дата рож.:{bank.B.ToString("dd:MM:yyyy")}");
                Console.WriteLine($"Возраст:{bank._age}");
                Console.WriteLine($"Ставка: {_rate}");
                return true;
            }
        }
    }
    class AEA
    {
        public string Message { get; }
        public int Sum { get; }
        public AEA(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
    class Account
    {
        public delegate void AH(object sender, AEA e);
        public event AH Notify;
        public double Sum { get; private set; }
        public Account(int sum)
        {
            Sum = sum;
        }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AEA($"Поступило на счет {sum}.", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AEA($"Сумма {sum} снята со счета.", sum));
            }
            else
            {
                Notify?.Invoke(this, new AEA("Нехватка средств на счете.", sum)); ;
            }
        }

        public static void SetAccAge(BankAccount bank)
        {
            bank.AgeAc = DateTime.Now;
            Console.WriteLine($"{bank.AgeAc} - создан ");
        }
        public void Rate(BankAccount bank)
        {
            double _rate = 0.03;
            double Wheel = 0;
            Wheel = Sum;
            DateTime Today = DateTime.Now;
            TimeSpan Age = Today.Subtract(bank.AgeAc);
            int secs = (int)Age.TotalSeconds;
            Console.WriteLine($" {Age} секунд прошло");
            while (secs >= 5)
            {
                secs = secs - 5;
                Sum = Sum + (Sum * _rate);
            }
            Console.WriteLine($"Вклад равен - {Sum} руб.");
            Sum = Wheel;
        }

    }

    class BankAcco
    {

        private static void DisplayMessage(object sender, AEA e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }

        public static void BnkAc()
        {
            BankAccount bank = new BankAccount();
            BankAccount.SetNSNIDA(bank);
            BankAccount.SetId(bank);
            BankAccount.SetAge(bank);
            if (BankAccount.GetNSNIDR(bank) == true)
            {
                Account acc = new Account(10);
                acc.Notify += DisplayMessage;
                acc.Put(120);
                acc.Take(70);
                acc.Take(150);
                int n = 0;
                while (n == 0)
                {
                    Console.WriteLine("Подсчитать ваш вклад?");
                    Console.ReadLine();
                    acc.Rate(bank);
                }
            }
        }
    }
}
