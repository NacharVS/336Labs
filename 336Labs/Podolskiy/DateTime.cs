using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class DATETime
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.021;
        private double _paymentAccount = 12000;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetter;
        }
        public void Deposit()
        {
            Console.WriteLine("Сколько хотите внести >>> ");

            double depos = Convert.ToDouble(Console.ReadLine());

            _paymentAccount = _paymentAccount + depos;

            Console.WriteLine("На вашем счету стало " + _paymentAccount);
        }

        public void Withdraw()
        {
            Console.WriteLine("Сколько хотите снять  >>> ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            _paymentAccount = _paymentAccount - withdraw;

            Console.WriteLine("На вашем счету осталось : " + _paymentAccount);
        }
    }
}