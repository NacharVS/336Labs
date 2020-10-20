﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Acadullin
{
    class StudentsList
    {
        public string _namestudent;
        private double _mathMark;
        private double _physicsMark;
        private double _chemistryMark;

        public StudentsList(string name, double math, double physics, double chemisrty)
        {
            _namestudent = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemisrty;
        }
    }
    class StudentSelection
    {
        //public static void Selection(StudentsList[] list, double AverageMark)
        //{
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >= AverageMark)
        //        {
        //            Console.WriteLine($"Студент {list[i]._namestudent} с такими оценками допущен к экзамену!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Студент {list[i]._namestudent} с такими оценками не допущен к экзамену!");
        //        }
        //    }
        //}
        public double _mathMark
        {
           get
            {
                return _mathMark;
            }
            set
            {
                if (value < 6 && value > 1)
                {
                    this._mathMark = value;
                }
                else 
                {
                    if (value > 5)
                    {
                        this._mathMark = 5;
                    }
                    else 
                    {
                        this._mathMark = 2;
                    }
                }
            }
}
    }
}