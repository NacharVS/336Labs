using System;

namespace _336Labs.Bitkova.Deligates
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Введите имя: ");
            account.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            account.SetSurname(Console.ReadLine());
            Console.WriteLine("Ваш ID: ");
            account.SetId();
            Console.WriteLine(account.GetID());
            Console.WriteLine("Ваша ставка: ");
            account.SetRate();
            Console.WriteLine(account.GetRate());
            Console.WriteLine("Введите свой день рождения.");
            account.Age();
            Console.WriteLine("Ваш счет: ");
            account.SetPaymentAccount(double.Parse(Console.ReadLine()));
            Console.WriteLine("Cколько хотите закинуть? ");
            account.SetSum(double.Parse(Console.ReadLine()));
            Console.WriteLine("Cколько хотите снять? ");
            account.SetMinus(double.Parse(Console.ReadLine()));
        }
    }
}
