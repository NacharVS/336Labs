using _336Labs.Sapegin;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Maksim", 4, 3, 4);
            list[1] = new StudentsList("Ilya", 4, 5, 4);
            list[2] = new StudentsList("Andrey", 5, 5, 4);
            list[3] = new StudentsList("Leonid", 3, 3, 3);
            list[4] = new StudentsList("Vasiliy", 4, 3, 5);
            Console.WriteLine($" {list[i]._name} acces granted");
        }
    }
}
