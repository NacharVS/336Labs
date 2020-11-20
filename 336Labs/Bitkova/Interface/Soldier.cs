using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Interface
{
    sealed class Soldier : ISoldier
    {
        private int _health;

        public int Health
        {
            get => _health;
            set => _health = value;
        }
    }
}
