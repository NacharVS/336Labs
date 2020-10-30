﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Melenteva
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
        }

        private int mark;
        public int Mark
        {

            get
            {
                return mark;
            }
            set
            {
                if (value < 0 || value > 3)
                {
                    mark = value;
                }
            }
        }

    }
    class StudentSelection
    {
        static void Selection(StudentsList[] list, double AverageMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark / 3 >= AverageMark))
                {
                    Console.WriteLine($"(list[i]._name) norm");
                }
            }
        }


    }
}  


        