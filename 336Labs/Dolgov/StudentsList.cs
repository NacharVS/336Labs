using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class StudentsList
    {
        public string _name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemistryMark;

        public StudentsList(string name, double math, double physics, double chemistry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemistry;
            PhysicsMark = _physicsMark;
            ChemistryMark = _chemistryMark;
            MathMark = _mathMark;
        }
        public string Name
        {
            set
            {
                if (value == "")
                {
                    _name = _name + "1";
                }
            }
        }
        public double MathMark
        {
            set
            {
                if (_mathMark > 5)
                {
                    _mathMark = 5;
                }
                if (_mathMark < 2)
                {
                    _mathMark = 2;
                }
            }
            get { return _mathMark; }
        }
        public double ChemistryMark
        {
            set
            {
                if (_chemistryMark > 5)
                {
                    _chemistryMark = 5;
                }
                if (_chemistryMark < 2)
                {
                    _chemistryMark = 2;
                }
            }
            get { return _chemistryMark; }
        }
        public double PhysicsMark
        {
            set
            {
                if (_physicsMark > 5)
                {
                    _physicsMark = 5;
                }
                if (_physicsMark < 2)
                {
                    _physicsMark = 2;
                }
            }
            get { return _physicsMark; }
        }

    }
    class StudentsSelection
    {
        public static void Selection(StudentsList[] list, double AverageMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 4 >= AverageMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted ");
                    Console.WriteLine($"{ list[i].MathMark},  {list[i].ChemistryMark},  {list[i].PhysicsMark}");
                }
            }
        }
    }
}
