using System;

namespace _336Labs.Sogorin
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Ivan", 5, 5, 5);
            list[0] = new StudentsList("Frank", 5, 4, 4);
            list[0] = new StudentsList("Jop", 5, 5, 4);
            list[0] = new StudentsList("Inga", 5, 3, 5);
            list[0] = new StudentsList("Rev", 3, 5, 4);
            Stsel.Sel(list, 4.0);
        }
    }
}
