using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
    interface IUnit
    {
        public double Health { get; set; }
        void Damage();
    }
}
