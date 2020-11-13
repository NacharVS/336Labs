using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Account
    {
        
        private static double _rate;
        private double _paymentac;
        public string _name;
        public string _surname;
        int _old;
        private int[] _id = { };
        public Account(string sur, string nam)
        {
            _surname = sur;
            _name = nam;
        }
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
            Account acc1 = new Account("Kuzak", "pvan");
            Account acc2 = new Account("Kuzap", "uvan");
            Account acc3 = new Account("Kuzam", "tvan");
            Account acc4 = new Account("Kuzan", "yvan");
            Account acc5 = new Account("Kuzab", "evan");
            
            for (int i = 0; i < Account.Lenght; i++)
            {
                
                if (j == i)
                {                    
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
        public BankAcc(int sum, string phnum)
        {
            _sum = sum;
            _phnum = phnum;
        }
        private int _sum;
        private string _phnum;
        public string Notify = "Massage ";
        public int Sum
        {

            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                //Notify?.Invoke(Phonnum);
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
