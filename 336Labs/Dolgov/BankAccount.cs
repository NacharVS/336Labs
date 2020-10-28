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
        public static double _rate = 0.067;
        private double _paymentAccount;
        private DateTime B = new DateTime();

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
            Console.WriteLine(bank.B);
            DateTime T = DateTime.Now;
            Console.WriteLine(T);
            bank._age = T.Year - bank.B.Year;
            Console.WriteLine(bank._age);
        }
        public static void GetNSNID(BankAccount bank)
        {
            Console.WriteLine($"Имя:{bank._name}");
            Console.WriteLine($"Фамилия:{bank._surname}");
            Console.WriteLine($"ID:{bank._id}");
            Console.WriteLine($"Дата рож.:{bank.B.ToString("dd:MM:yyyy")}");
            Console.WriteLine($"Возраст:{bank._age}");
        }
        public void Dep()
        {
            Console.WriteLine("Какую сумму хотите положить на счет?");

            double DE = Convert.ToDouble(Console.ReadLine());

            _paymentAccount = _paymentAccount + DE;

            Console.WriteLine("Ваш баланс:" + _paymentAccount);
        }
        public void WD()
        {
            Console.WriteLine("Какую сумму хотите снять со счета?");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;
            Console.WriteLine("Ваш баланс: " + _paymentAccount);
        }
    }
    class BankAcсo
    {
        public static void BankAcc()
        {
            BankAccount bank = new BankAccount();
            BankAccount.SetNSNIDA(bank);
            BankAccount.SetId(bank);
            BankAccount.SetAge(bank);
            BankAccount.GetNSNID(bank);
            int n = 1;
            while (n > 0)
            {
                bank.Dep();
                bank.WD();
            }
        }
    }
}
