using _336Labs.Galimzyanov;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> list = new List<BankAccount>();
            list.Add(new BankAccount("Platina", 45, 77777));
            list.Add(new BankAccount("OG", 19, 76677));
            list.Add(new BankAccount("Feduk", 43, 66666));
        }
    }
}
