using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    interface IUnits
    {
        void Damage();
    }

    abstract class UnitStats
    {
        int health;

        int defense;
        int min_damage;
        int max_damage;

    }


    class NotMain
    {
        public static void Game()
        {
            
        }
    }
}
