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
                                Console.WriteLine();
                            }
                        }
                    }
                }

            }


        }
    }
    

}
