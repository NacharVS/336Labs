using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
    class BankAccoun
    { 
        {
            private string _name;
            private string _surname;
            private string _id;
            private double _payment;
            private double _contribution;
            private double _removal;
            private static double _rate = 7.7;
        
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetters = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetters.ToString().ToUpper() + otherLetters;
        }


    }
}
