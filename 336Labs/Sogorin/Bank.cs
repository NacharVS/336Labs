using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Account
    {
        private static double _rate;
        private double _paymentac;
        string _name;
        string _surname;
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
            //for (int i = 0; i < length; i++)
            //{
            //    if (j == )
            //    {
            //        Console.WriteLine(_name + " " + _surname);
            //    }
            //    Console.WriteLine();
            //}            
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
         
    }
    class BankAcc
    {        
      
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
