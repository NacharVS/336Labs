using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
     class Villager : IUnit
    {
        private double _health;

        public double Health
        {
            get => _health;
            set
            {
                _health -= 5;
            }
        }
        public void Damage()
        {
            Console.WriteLine("К крестьянину применён урон.");
            Console.WriteLine($"Здоровье {_health}");
        }

    }
}
