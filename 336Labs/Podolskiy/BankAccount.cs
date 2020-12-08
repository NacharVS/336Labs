using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class BankAccount
    {

        private string _name;
        private string _surname;
         string _id;
         static double _rate = 0.021;
        private double _paymentAccount = 12000;



        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetter;
        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetter = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetter.ToString().ToLower();
        }
        public void Deposit()
        {
            Console.WriteLine("Сколько хотите внести >>> ");

            double depos = Convert.ToDouble(Console.ReadLine());

            _paymentAccount = _paymentAccount + depos;

            Console.WriteLine("На вашем счету стало " + _paymentAccount);
        }



        public void Withdraw()
        {
            Console.WriteLine("Сколько хотите снять  >>> ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;

            Console.WriteLine("На вашем счету осталось : " + _paymentAccount);
        }
        public void MethodDate()
        {
            DateTime dayOfBirthday = new DateTime();
            int toYear = DateTime.Now.Year;

            Console.WriteLine("Введите ваш год рождения");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц, когда вы родились");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день, когда вы родились");
            int days = int.Parse(Console.ReadLine());

            DateTime dayOfBirth = new DateTime(2002, 4, 4);

            dayOfBirth.AddYears(years);
            dayOfBirth.AddMonths(month);
            dayOfBirth.AddDays(days);

            Console.WriteLine($"Год: {years} Месяц:{month} День:{days}");

            Console.WriteLine("Вам сейчас: ");
            Console.WriteLine(toYear - years);
        }

    }
    public int Sum { get; }

    public AccountEventArgs(string mes, int sum)
    {
        Message = mes;
        Sum = sum;
    }
}
class Account
{
    public delegate void AccountHandler(object sender, AccountEventArgs e);
    public event AccountHandler Notify;
    public int Sum { get; private set; }
    public Account(int sum)
    {
        Sum = sum;
    }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
        }
    }
}

class Rate
{

}

class BA
{

    private static void DisplayMessage(object sender, AccountEventArgs e)
    {
        Console.WriteLine($"Сумма транзакции: {e.Sum}");
        Console.WriteLine(e.Message);
    }

    public static void BnkAc()
    {
        BankAccount bank = new BankAccount();
        BankAccount.SetNameSurnameIdAge(bank);
        BankAccount.SetId(bank);
        BankAccount.SetAge(bank);
        if (BankAccount.GetNameSurnameIdAgeRate(bank) == true)
        {
            Account acc = new Account(10);
            acc.Notify += DisplayMessage;
            acc.Put(120);
            acc.Take(70);
            acc.Take(150);
            Console.Read();
        }
    }
}
}
}