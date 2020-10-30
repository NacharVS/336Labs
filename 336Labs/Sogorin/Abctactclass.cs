using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Abctactclass
    {
        abstract class Info
        {            
            public string Name { get; set; }
            public string Surname { get; set; }
            public Info(string surname, string name)
            {
                surname = Surname;
                name = Name;
            }

            public void shInfo()
            {
                Console.WriteLine($"{Surname} {Name}");
            }
        }
        class Acc : Info
        {
            public int Old { get; set; }

            public Client(string name, int old)
                : base(name)
            {
                Old = old;
            }
        }
    }
}
