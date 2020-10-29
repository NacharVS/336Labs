using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private double _id;
        private static double _rate = 6.7;
        private double _paymentAccount;
        private int _age;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstletter = newName[0];
            var otherletters = newName.Remove(0, 1);
            _name = firstletter.ToString().ToUpper() + otherletters;
            Console.WriteLine("Ведите имя: ");
            newName = Console.ReadLine();
        }

        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters;
            Console.WriteLine("Ведите Фамилию: ");
            newSurname = Console.ReadLine();

        }

        public void SetId(int newID)
        {
            Random rnd = new Random();
            int[] ID = new int[1];
            for (int i = 0; i < ID.Length; i++)
            {
                ID[i] = rnd.Next(0, 1000);
            }
            _id = newID;
        }
        public double GetRate()
        {
            return _rate;
        }

        public void SetRate(double Rate)
        {
            _rate = Rate;
        }

        public void SetAge(double age)
        {
            DateTime nowDate = DateTime.Today;
            double birthDate = double.Parse(Console.ReadLine());
            age = nowDate.Year - birthDate;
            if(age < 14)
            {
                Console.WriteLine("Вы слишком молоды чтобы заводить свой счёт");
            }
            else
            {
                return;
            }
        }

        public void SetPaymentAccount(double newPaymentAccount)
        {
            _paymentAccount = newPaymentAccount;
            double depos = Convert.ToDouble(Console.ReadLine());
            newPaymentAccount = newPaymentAccount + depos;
            Console.WriteLine("На вашем счету стало " + newPaymentAccount);
            Console.WriteLine("Сколько хотите снять?");
            int a = int.Parse(Console.ReadLine());
            newPaymentAccount = newPaymentAccount - a;
            Console.WriteLine("На вашем счету стало " + newPaymentAccount);

        }

        public void SetPaymentAccount2(double newPaymentAccount2)
        {
            _paymentAccount = newPaymentAccount2;
            int a = int.Parse(Console.ReadLine());
            newPaymentAccount2 = newPaymentAccount2 - a;
            Console.WriteLine("На вашем счету стало " + newPaymentAccount2);

        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Введите имя: ");
            account.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            account.SetPaymentAccount(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Сколько хотите внести?");
            account.SetPaymentAccount2(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Сколько хотите снять?");

        }
    }
}
