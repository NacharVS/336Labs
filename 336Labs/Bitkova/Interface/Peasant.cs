using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Interface
{
    sealed class Peasant : IPeasant
    {
        private int _health;
        private double _scream;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public double Scream
        {
            get => _scream;
            set => _scream = value;
        }
    }
}
