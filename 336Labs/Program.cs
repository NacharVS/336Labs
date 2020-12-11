using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _336Labs.Farkhutdinov;

namespace _336Labs
{
    class Progra
    {
        static void Main(string[] args)

        {
            List<BankAccount> ClientsList = new List<BankAccount>();
            ClientsList.Add(new BankAccount("Azat", "Bayburin", "30.10.2002", "+7966666666", 666 ));
            ClientsList.Add(new BankAccount("Ainur", "Farkhutdiniv", "19.05.2003", "+7977777777", 777));
            ClientsList.Add(new BankAccount("Amir", "Galimzyanov", "25.04.2002", "+792222222", 222));
            
        }
    }
}
