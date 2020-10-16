using _336Labs.Galimzyanov;
using System;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentslist Azat = new Studentslist("Azat", 4, 5, 2);
            Studentslist Amir = new Studentslist("Amir", 5, 4, 3);
            Studentslist Aizat = new Studentslist("Aizat", 2, 2, 3);
            Studentslist Adel = new Studentslist("Adel", 5, 4, 5);
            Studentslist Bulat = new Studentslist("Bulat", 5, 5, 3);
            Studentslist[] studentslists = new Studentslist[5];
            studentslists[0] = Azat;
            studentslists[1] = Amir;
            studentslists[2] = Aizat;
            studentslists[3] = Adel;
            studentslists[4] = Bulat;
            StudentSelection.Selection(studentslists, 4);

        }
    }
}
