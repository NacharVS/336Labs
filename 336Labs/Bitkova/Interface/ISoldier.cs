using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Interface
{
    interface ISoldier
    {
        void Work();
        public int Health { get; set; }
        void SoldierHealth();
    }
}
