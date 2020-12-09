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
        
       public Account(string sur, string nam)
        {
            _surname = sur;
            sur = sur.Trim();
            var firstLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _surname = firstLet1.ToString().ToUpper() + lastLet1;

            _name = nam;
            nam = nam.Trim();
            var firstLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;
        }
        public void GetSu(string sur)
        {
                                
        }  
        public void GetNa(string nam)
        {
            
        }
        public void shinfo(int j)
        {
            List<Account> AccLis = new List<Account>();
            AccLis.Add(new Account("Kuzak", "pvan"));
            AccLis.Add(new Account("Kuzap", "uvan"));
            AccLis.Add(new Account("Kuzam", "tvan"));
            AccLis.Add(new Account("Kuzan", "yvan"));
            AccLis.Add(new Account("Kuzab", "evan"));

            //foreach (var j in AccLis)
            //{
            //    Console.WriteLine(_name + " " + _surname);
            //    Console.WriteLine();
            //}           

        }        
        public void Getold()
        {
            //DateTime;
        }
    }
    class BankAcc
    {        
        private int _sum;
        private string _phnum;
        public string Notify = "Massage ";
        private int[] _id = { };
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
        public void Getid()
        {
            Random rnd = new Random();
            string[] Accid = { };

            for (int j = 0; j < Accid.Length; j++)
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
