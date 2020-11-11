using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Account
    {
        private int _sum;
        private string _phnum;
        public void BankAccount(int sum, string phnum)
        {
            _sum = sum;
            _phnum = phnum;
        }
        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                Notify?.Invoke(Phonnum);
            }
        }
        public string Phonnum
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
            
            for (int i = 0; i < Table.Length; i++)
            {
                
                if (j == i)
                {
                    Console.WriteLine(Table[i]);
                    //Console.WriteLine(_name + " " + _surname);
                    //Console.WriteLine();
                }
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

/*
 *class BankAcc
    {
        private string _name;
        private string _surname;
        private int[] _id = {};
        private static double _rate;
        private double _paymentac;

        public void Setname(string newName)
        {
            newName = newName.Trim();
            var firstLet = newName[0];
            var lastLet = newName.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;            
        }
        
        public void Setsurname(string newsurName)
        {
            newsurName = newsurName.Trim();
            var firstLet = newsurName[0];
            var lastLet = newsurName.Remove(0, 1);
            _surname = firstLet.ToString().ToUpper() + lastLet;
        }
        
        public void Getid(string us)
        {
            Random rnd = new Random();            
            string[] Accid = {};
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
        public void info()
        {
            Console.WriteLine(mass);
        }
        public void showinfo(int num)
        {
            Console.WriteLine(_id[num] + _name[num] + _surname[num]);
        }
    } 
*/
