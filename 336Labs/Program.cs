﻿using _336Labs.Kolpakova;
using System;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList Kolpakova = new StudentsList("Kolpakova", 5, 4, 5);
            StudentsList Ziatdinova = new StudentsList("Ziatdinova", 4, 5, 5);
            StudentsList Zalyalov = new StudentsList("Zalyalov", 4, 3, 4);
            StudentsList Galimzyanov = new StudentsList("Galimzyanov", 5, 3, 3);
            StudentsList Daminov = new StudentsList("Daminov", 4, 5, 4);
            StudentsList Dolgov = new StudentsList("Dolgov", 3, 2, 5);
            StudentsList[] studentsLists = new StudentsList[6];
            studentsLists[0] = Kolpakova;
            studentsLists[1] = Ziatdinova;
            studentsLists[2] = Zalyalov;
            studentsLists[3] = Galimzyanov;
            studentsLists[4] = Daminov;
            studentsLists[5] = Dolgov;
            StudentSelection.Selection(studentsLists, 5);
        }
    }
}
