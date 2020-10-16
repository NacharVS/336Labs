using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class StudentsList
    {

        public string _name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemistryMark;

        public StudentsList(string name, double math, double physics, double chemisiry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemisiry;
        }
    }
    class StudentSeletion
    {
        static void Selection(StudentsList[] list, double AveregeMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i]._mathMark + list[i]._physicsMark + list[i]._physicsMark + list[i]._chemistryMark / 3 >= AveregeMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted");
                }
            }
        }
    }
}
