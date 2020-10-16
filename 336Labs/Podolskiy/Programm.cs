using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Podolskiy
{
    class Programm
    {
        static void Main(string[] args)
        {
            StudentList[] list = new StudentList[5];
            list[0] = new StudentsList("Ivan", 5, 3, 4);
            list[1] = new StudentsList("Victor", 3, 3, 4);
            list[2] = new StudentsList("Ekaterina", 5, 5, 5);
            list[3] = new StudentsList("Idris", 5, 4, 4);
            list[4] = new StudentsList("Kolyan", 3, 3, 3);

            StudentSelection.Selection(list, 3.9);
        }
    }
}
