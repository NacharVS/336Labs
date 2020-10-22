using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class BankAcc
    {
        private string _name;
        private string _surname;
        private int[] _id = {};
        private static double _rate;
        private double _paymentacc;

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
                if (_name == us)
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
}
