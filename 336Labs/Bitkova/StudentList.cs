using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova
{
    class StudentList
    {
        public string _name;
        public double _mathMark;
        public double _englishMark;
        public double _historyMark;
        public double _literatureMark;
        public double _physicsMark;
        public double _informaticsMark;

        public StudentList(string name, double math, double english, double history, double literature, double physics, double informatics)
        {
            _name = name;
            _mathMark = math;
            _englishMark = english;
            _historyMark = history;
            _literatureMark = literature;
            _physicsMark = physics;
            _informaticsMark = informatics;
        }
    }

    class StudentSelection
    {
        static void Selection(StudentList[] list, double AverageMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._englishMark + list[i]._historyMark + list[i]._literatureMark + list[i]._physicsMark + list[i]._informaticsMark) / 3 >= AverageMark)
                {
                    Console.WriteLine($" {list[i]._name} access granted");
                }
            }
        }

        static void Main(string[] args)
        {
            StudentList[] list = new StudentList[5];
            list[0] = new StudentList("Oksana", 3, 4, 4, 5, 3, 5);
            list[1] = new StudentList("Angela", 3, 3, 4, 4, 2, 4);
            list[2] = new StudentList("Leila", 5, 5, 5, 5, 5, 5);
            list[3] = new StudentList("Kamilla", 3, 4, 4, 5, 4, 2);
            list[4] = new StudentList("Karina", 3, 4, 3, 5, 5, 2);
        }
    }
}
