using System;
using System.Collections.Generic;
using System.Text;
using _336Labs.Farkhutdinov;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(0, "+7952845845");
            account1.Notify += MessageSending;
            account1.RateChangedEvent += RateChangednotify;
            Console.WriteLine($"Cостояние счёта {account1.Balance}");
            account1.SetBalanceRep(1500);
            Console.WriteLine($"Cостояние счёта {account1.Balance}");
            account1.SetBalanceRem(1000);
            Console.WriteLine($"Cостояние счёта {account1.Balance}");
            account1.SetRate(0.05);
        }
        public static void MessageSending(string phoneNumber)
        {
            Console.WriteLine($"Сообщение о совершение операции отправлено на номер : {phoneNumber}");
        }
        public static void RateChangednotify(double oldRate, double newRate)
        {
            Console.WriteLine($"Старая процентная ставка {oldRate} изменина на {newRate}");
        }
    }
}
