using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class Studentslist
    {
        public string _name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemistryMark;

        public Studentslist(string name, double math, double physics, double chemistry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = chemistry;
        }
    }
    class StudentSelection
    {
        static void Selection(Studentslist [] list, double AverageMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >== AverageMark)
            }
        }
    }
}

