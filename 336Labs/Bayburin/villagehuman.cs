using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bayburin
{
    sealed class villagehuman : Interface1
    {
        private double _health;
        private double _energy;

        public double Health
        {   get => _health;
            set => _health = value;
        }

        public double Energy
        {
            get => _energy;
            set => _energy = value;
        }
         
        public void hel()
        {
            Console.WriteLine($"health = {_health} hp");
        }
        
        public void en()
        {
            Console.WriteLine($"energy = {_energy}");
        }
        

    }
}
