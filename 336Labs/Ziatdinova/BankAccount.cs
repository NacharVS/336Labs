using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova
{
    class BankAccount
    {
        private string _name;
        private string _SURNAME;
        private int[] _id = { };
        private static double _rate;
        private double _paymentAccount;
        private string _surname;
        private string v1;
        private string v2;

        public BankAccount(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static int Lenght { get; private set; }

        public void list(string sur, string nam)
        {
            nam = nam.Trim();
            var oneLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = oneLet.ToString().ToUpper() + lastLet;

            sur = sur.Trim();
            var oneLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _SURNAME = oneLet1.ToString().ToUpper() + lastLet1;
        }

        public void shinfo(int j)
        {
            BankAccount acc1 = new BankAccount("Kuzak", "pvan");
            BankAccount acc2 = new BankAccount("Kuzap", "uvan");
            BankAccount acc3 = new BankAccount("Kuzam", "tvan");
            BankAccount acc4 = new BankAccount("Kuzan", "yvan");
            BankAccount acc5 = new BankAccount("Kuzab", "evan");

            for (int i = 0; i < BankAccount.Lenght; i++)
            {
                if (j == 1)
                {
                    Console.WriteLine(_name + " " + _surname);
                    Console.WriteLine();
                }
            }
        }

        public void Getid(string us)
        {
            Random rndm = new Random();
            string[] Accid = { };
            for (int j = 0; j < Accid.Length; j++)
            {
                if (_SURNAME == us)
                {
                    for (int i = 0; i < _id.Length; i++)
                    {
                        if (i == j)
                            Console.WriteLine(_id[i]);
                        else
                        {
                            if (i == _id.Length)
                            {
                                _id[i] = rndm.Next(000000, 100000);
                                Console.WriteLine(_id[i]);
                            }
                        }
                    }
                }

            }


        }
    }
    

}
class BankAcc
{
    public BankAcc(int sum, string phnum)
    {
        int _sum = sum;
        string _phnum = phnum;
    }
    private int _sum;
    private _phnum;
    public string Notify = "Message";
    
    public int Sum
    {
        get
        {
            return _sum;
        }
        set
        {
            _sum = value;
        }
    }
    public string Phonnumm
    {
        get
        {
            return _phnum;
        }
        set
        {
            _phnum = value;
        }
    }
}

    