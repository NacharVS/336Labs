using System;

namespace _336Labs.Bitkova
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("+79003279046");
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
            account.Notify += MessageSetting;
            Console.WriteLine("Cколько хотите закинуть? ");
            account.SetSum(double.Parse(Console.ReadLine()));
            account.Notify += MessageSetting2;
            Console.WriteLine("Cколько хотите снять? ");
            account.SetMinus(double.Parse(Console.ReadLine()));
        }

       public static void MessageSetting(string phoneNumber)
        {
            Console.WriteLine($"На {phoneNumber} поступила сумма");
        }
        public static void MessageSetting2(string phoneNumber)
        {
            Console.WriteLine($"На {phoneNumber} сняли сумму");
        }
    }
}
