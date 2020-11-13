using _336Labs.Galimzyanov;
using System;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(500, "+79503930219");
            Console.WriteLine($"account condition: {acc1.Sum}");
            acc1.Vnesti(50);
            Console.WriteLine($"Message sended at {acc1.PhoneNumber}");
            Console.WriteLine($"account condition: {acc1.Sum}");
        }
    }
}
