using _336Labs.Zalyalov;
using System;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Omar", 4, 4, 5);
            list[1] = new StudentsList("Bulat", 3, 4, 3);
            list[2] = new StudentsList("Azat", 3, 3, 3);
            list[3] = new StudentsList("Podol", 3, 2, 3);
            list[4] = new StudentsList("Naimon", 4, 3, 4);
            StudentsSelection.Selection(list, 3);
        }
    }
}