using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 6.7 ;
        private double _paymentAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstletter = newName[0];
            var otherletters = newName.Remove(0, 1);
            _name = firstletter.ToString().ToUpper() + otherletters;
               
        }

        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters;
            
        }
        
        public void SetId(string newId)
        {
            int[] ID = new int[10];
            ID[0] = 0;
            ID[1] = 1;
            ID[2] = 2;
            ID[3] = 3;
            ID[4] = 4;
            ID[5] = 5;
            ID[6] = 6;
            ID[7] = 7;
            ID[8] = 8;
            ID[9] = 9;
            
            for (int i = 3; ID.Length; i++)
            {



            }


        }

        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            account.SetName(Console.ReadLine());
            account.SetSurname(Console.ReadLine());
            BankAccount._rate = 0.089;
            Console.WriteLine(BankAccount._rate);
            
        }
    }
}
