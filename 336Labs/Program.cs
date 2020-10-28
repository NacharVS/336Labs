using System;

namespace _336Labs.didikova
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            BankAcc[] Table = new BankAcc[10];
            Table[0] = new BankAcc("Kuzak", "pvan");
            Table[1] = new BankAcc("Kuzap", "uvan");
            Table[2] = new BankAcc("Kuzam", "tvan");
            Table[3] = new BankAcc("Kuzan", "yvan");
            Table[4] = new BankAcc("Kuzab", "evan");
            Table[5] = new BankAcc("Kuzac", "qvan");
            Table[6] = new BankAcc("Kuzax", "dvan");
            Table[7] = new BankAcc("Kuzaz", "gvan");
            Table[8] = new BankAcc("Kuzal", "jvan");
            Table[9] = new BankAcc("Kuzaj", "avan");
            account.shinfo(1);
        }
    }
}
