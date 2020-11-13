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
            Console.WriteLine("Ваша ставка: ");
            account.SetRate();
            Console.WriteLine(account.GetRate());
            Console.WriteLine("Введите свой день рождения.");
            account.Age();
            Console.WriteLine($"Ваш счет: {account.Sum}");
            Console.WriteLine("Сколько хотите закинуть?");
            account.Notify += MessageSetting;
            account.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваш счет: {account.Sum}");
            Console.WriteLine("Сколько хотите снять?");
            account.Notify += MessageSetting2;
            account.Widthraw(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваш счет: {account.Sum}");
        }

       
        
        public static void MessageSetting(string phoneNumber)
        {
            Console.WriteLine($"На {phoneNumber} поступила сумма");
        }

        public static void MessageSetting2(string phoneNumber)
        {
            Console.WriteLine($"С {phoneNumber} сняли сумму");
        }
    }
}
