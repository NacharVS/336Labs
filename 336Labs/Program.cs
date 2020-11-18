using System;

namespace _336Labs.Bitkova
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("+79003279046", 5000);
            Console.WriteLine("Введите имя: ");
            account.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            account.SetSurname(Console.ReadLine());
            Console.WriteLine("Ваш ID: ");
            account.SetId();
            Console.WriteLine(account.GetID());
            account.RateChangedEvent += RateMessage;
            Console.WriteLine($"Ваша ставка: {account.Rate}");
            account.newRate(0.47);
            Console.WriteLine($"Ваша ставка: {account.Rate}");
            Console.WriteLine("Введите свой день рождения.");
            account.Age();
            Console.WriteLine($"Ваш счет: {account.Sum}");
            account.PhoneNumberEvent += MessageSetting;
            Console.WriteLine("Сколько хотите закинуть?");
            account.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваш счет: {account.Sum}");
            Console.WriteLine("Сколько хотите снять?");
            account.Widthraw(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваш счет: {account.Sum}");
            Console.WriteLine("Вы взяли кредит, случайно)))");
        }

       
        
        public static void MessageSetting(string phoneNumber)
        {
            Console.WriteLine($"Message send at {phoneNumber}");
        }
        public static void RateMessage(double oldRate, double newRate)
        {
            Console.WriteLine($"Old rate {oldRate} changed to {newRate}");
        }
    }
}
