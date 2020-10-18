using _336Labs.Ziatdinova;
using System;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList Ksenia = new StudentsList("Ksenia", 5, 4, 2);
            StudentsList Liana = new StudentsList("Liana", 3, 4, 5);
            StudentsList Karina = new StudentsList("Karina", 2, 3, 2);
            StudentsList Danil = new StudentsList("Danil", 5, 4, 5);
            StudentsList Bulat = new StudentsList("Bulat", 5, 3, 5);
            StudentsList[] studentslists = new StudentsList[5];
            studentslists[0] = Ksenia;
            studentslists[1] = Liana;
            studentslists[2] = Karina;
            studentslists[3] = Danil;
            studentslists[4] = Bulat;
            StudentSelection.Selection(studentslists, 4);

        }
    }
}
