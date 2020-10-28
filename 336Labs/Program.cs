using _336Labs.Yusupov;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();

            bank.SetName("даня");
            bank.SetName("кашин "); 
             
            bank.Deposit();
            bank.Withdraw();
            bank.MethodDates(); 
 
        }
    }
}
