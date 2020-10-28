using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.didikova
{
    class Account
    {
        private static double _rate;
        private double _paymentac;
        public string _name;
        public string _surname;
        int _old;
        private int[] _id = { };
        public void spisok(string sur, string nam)
        {
            nam = nam.Trim();
            var firstLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;

            sur = sur.Trim();
            var firstLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _surname = firstLet1.ToString().ToUpper() + lastLet1;


        }
        public void shinfo(int j)
        {
            BankAcc[] reg = new BankAcc[10];
            for (int i = 0; i < reg.Length; i++)
            {
                if (j == i)
                {
                    Console.WriteLine(_name + " " + _surname);
                }
                Console.WriteLine();
            }
        }
        public void Getid(string us)
        {
            Random rnd = new Random();
            string[] Accid = { };

            for (int j = 0; j < Accid.Length; j++)
            {
                if (_surname == us)
                {
                    for (int i = 0; i < _id.Length; i++)
                    {
                        if (i == j)
                            Console.WriteLine(_id[i]);
                        else
                        {
                            if (i == _id.Length)
                            {
                                _id[i] = rnd.Next(000000, 100000);
                                Console.WriteLine(_id[i]);
                            }
                        }
                    }
                }
            }
        }
        public void Getold()
        {
            //DateTime;
        }
    }
    class BankAcc
    {
        public BankAcc(string sur, string nam)
        {
            Account account = new Account();
            account._surname = sur;
            account._name = nam;
        }

    }
}
