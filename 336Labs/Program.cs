using System;

namespace _336Labs.Bitkova.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здание");
            IBuilding buildobject;
            buildobject = new Building();
            buildobject.Stand();

            Console.WriteLine("--------------------");

            Console.WriteLine("Крестьянин");
            IPeasant peasantobject;
            peasantobject = new Peasant();
            peasantobject.Health = 100;
            peasantobject.PeasantHealth();
            peasantobject.Work();

            Console.WriteLine("--------------------");

            Console.WriteLine("Воин");
            ISoldier soldierobject;
            soldierobject = new Soldier();
            soldierobject.Health = 100;
            soldierobject.SoldierHealth();
            soldierobject.Work();

            Console.WriteLine("--------------------");
        }
    }
}
