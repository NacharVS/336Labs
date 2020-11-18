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
            BankAccount account1 = new BankAccount();
            account1.SetPhoneNumber("+7985285485");
            account1.Notify += MessageSending;
            account1.SetBalanceRep(1500);
            account1.SetBalanceRem(1000);
            account1.RateChangedEvent += RateChangednotify;
            account1.SetRate(0.55);
        }
        public static void MessageSending(string phoneNumber)
        {
            Console.WriteLine(phoneNumber);
        }
        public static void RateChangednotify(double oldRate, double newRate)
        {
            Console.WriteLine($"Old rate {oldRate} changed to {newRate}");
        }
    }
}
