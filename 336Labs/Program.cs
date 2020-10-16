using System;
using _336Labs.Acadullin;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Aizat", 5, 5, 4);
            list[1] = new StudentsList("Azat", 4, 3, 4);
            list[2] = new StudentsList("Amir", 2, 5, 3);
            list[3] = new StudentsList("Ainur", 2, 3, 4);
            list[4] = new StudentsList("Bulat", 5, 3, 4);

            StudentSelection.Selection(list, 4);
        }
    }
}
