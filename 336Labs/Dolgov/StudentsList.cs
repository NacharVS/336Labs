﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class StudentsList
    {
        public string _name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemisrtyMark;

        public StudentsList(string name, double math, double physics, double chemistry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemisrtyMark = chemistry;
        }
    }

    class StudentsSelection
    {
        public static void Selection(StudentsList[] list, double AverageMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemisrtyMark) / 3 >= AverageMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted ");
                }
            }
        }
    }
}
