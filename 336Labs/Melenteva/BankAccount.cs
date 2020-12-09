using _336Labs.Melenteva;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _336Labs.Melenteva
{
    class BankAccount
    {
        
        private string _name;
        private string _surname;
        private static int _id, _age;
        public static double _rate = 0.67;
        private DateTime Birth = new DateTime();
        public DateTime AccAge = DateTime.Now;

        public BankAccount(int v)
        {
        }

        public BankAccount()
        {
        }

        public Action<object, AccEventAr> Notify { get; internal set; }

        public void SetName(string nName)
        {
            nName = nName.Trim();
            var firstLetter = nName[0];
            var oLetters = nName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + oLetters.ToString().ToLower();
        }
        public void SetSurName(string nSurName)
        {
            nSurName = nSurName.Trim();
            var firstLetter = nSurName[0];
            var oLetters = nSurName.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + oLetters.ToString().ToLower();

        }

        public void SetAge(DateTime nAge)
        {
            DateTime Birth = DateTime.Now.Date;
        }
        public double GetRate()
        {
            return _rate;
        }
        public void SetRate(double rate)
        {
            _rate = rate;
        }

        public void SetId(string v)
        {
            Random rnd = new Random();
            _id = rnd.Next(10, 100);

        }
        public static void SetNSNIDA(BankAccount bank)
        {
            Console.WriteLine("Write your name");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Write your SurName");
            bank.SetSurName(Console.ReadLine());
        }

        public static void SetAge(BankAccount bank)
        {
            Console.WriteLine("Enter year of your birth ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth ");
            int d = Convert.ToInt32(Console.ReadLine());
            bank.Birth = new DateTime(y, m, d);
            DateTime T = DateTime.Now;
            _age = T.Year - bank.Birth.Year;
            Console.WriteLine();
        }

        public static bool GetNSNIDR(BankAccount bank)
        {
            if (_age < 18)
            {
                Console.WriteLine("You are too young to open an account.");
                return false;
            }
            else
            {
                Console.WriteLine($"Name:{bank._name}");
                Console.WriteLine($"SurName:{bank._surname}");
                Console.WriteLine($"ID:{_id}");
                Console.WriteLine($"Date of Birth:{bank.Birth.ToString("d:M:y")}");
                Console.WriteLine($"age:{_age}");
                Console.WriteLine($"rate: {_rate}");
                return true;
            }
        }

        internal static void SetId(BankAccount bank1)
        {
            throw new NotImplementedException();
        }

        internal void Put(int v)
        {
            throw new NotImplementedException();
        }

        internal void Take(int v)
        {
            throw new NotImplementedException();
        }

        internal void Rate(BankAccount bank)
        {
            throw new NotImplementedException();
        }
    }

}
class AccEventAr
{
    public string Message { get; }
    public int Sum { get; }
    public AccEventAr(string mes, int sum)
    {
        Message = mes;
        Sum = sum;
    }
}

class Acc

{
    public delegate void AccHandler(object sender, AccEventAr e);
    public event AccHandler Notify;
    public int Sum { get; private set; }
    public Acc(int sum)
    {
        Sum = sum;
    }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccEventAr($"The account received {sum}.", sum));
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccEventAr($"Summ {sum} withdrawn from the account", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccEventAr("Lack of funds in the account", sum)); ;
        }
    }

    public static void SetAccAge(BankAccount bank)
    {
        bank.AccAge = DateTime.Now;
        Console.WriteLine($"{bank.AccAge} - создан ");
    }
    public void Rate(BankAccount bank)
    {
        double _rate = 0.03;
        double Wheel = 0;
        Wheel = Sum;
        DateTime Today = DateTime.Now;
        TimeSpan Age = Today.Subtract(bank.AccAge);
        int secs = (int)Age.TotalSeconds;
        Console.WriteLine($" {Age} секунд прошло");
        while (secs >= 5)
        {
            secs = secs - 5;
            Sum = (int)(Sum + (Sum * _rate));
        }
        Console.WriteLine($"Вклад равен - {Sum} руб.");
        Sum = (int)Wheel;
    }



}

class BankAcc
{
    private static void DisplayMessage(object sender, AccEventAr e)
    {
        Console.WriteLine($"Transaction amount: {e.Sum}");
        Console.WriteLine(e.Message);
    }
    public static void BankAc()
    {
        BankAccount bank = new BankAccount();
        BankAccount.SetNSNIDA(bank);
        BankAccount bank1 = bank;
        BankAccount.SetId(bank1);
        BankAccount.SetAge(bank);
        if (BankAccount.GetNSNIDR(bank) == true)
        {
            BankAccount acc = new BankAccount(10);
            acc.Notify += DisplayMessage;
            acc.Put(120);
            acc.Take(70);
            acc.Take(150);
            int n = 0;
            while (n == 0)
            {
                Console.WriteLine("Calculate your contribution?");
                Console.ReadLine();
                acc.Rate(bank);
            }
        }
    }

    static void Main(string[] args)
    {

    }
    
}
