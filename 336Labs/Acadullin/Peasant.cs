using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    interface IPeasant
    {
        class peasant : IPeasant
        {
            private double _says;
            public double Says
            {
                get => _says;
                set => _says = value;
            }

            public void Move()
            {
                Console.WriteLine($"Кретиянин сказал боярину - {_says}");
            }

        }

    }
}
