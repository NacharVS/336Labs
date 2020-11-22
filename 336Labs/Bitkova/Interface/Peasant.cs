using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Interface
{
    sealed class Peasant : IPeasant
    {
        private int _health;

        public void Work()
        {
            Console.WriteLine("Крестьянин работает");
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public void PeasantHealth()
        {
            Console.WriteLine($"Здоровье крестьянина - {_health}");
        }
    }
}
