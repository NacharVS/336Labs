using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class SL
    {
        public static void StL()
        {
            Console.WriteLine("Введите среднюю оценку");
            double AveregeMark = Convert.ToDouble(Console.ReadLine());
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Splinter", 1, 7, 7);
            list[1] = new StudentsList("Leonardo", 6, 5, 5);
            list[2] = new StudentsList("Raphael", 3, 4, 5);
            list[3] = new StudentsList("Donatello", 5, 5, 5);
            list[4] = new StudentsList("Michelangelo", 3, 2, 3);
            StudentSelection.Selection(list, AveregeMark);
        }
    }
    class StudentsList
    {

        public string _name;
        private double _mathMark;
        private double _physicsMark;
        private double _chemistryMark;

        public StudentsList(string name, double math, double physics, double chemisiry)
        {
            _name = name;

            _mathMark = math;
            MathMark = _mathMark;
            _physicsMark = physics;
            PhysicsMark = physics;
            _chemistryMark = chemisiry;
            ChhemistryMark = chemisiry;
        }
        /*        public static void Name1 (StudentsList[] list)
                {

                }*/

        /*public string Name
        {
            set
            {
                if (value == )
                {
                    _name = _name + "1";
                }
            }

        }*/
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
        public double ChhemistryMark
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
    class StudentSelection
    {
        public static void Selection(StudentsList[] list, double AveregeMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].MathMark + list[i].ChhemistryMark + list[i].PhysicsMark / 3 >= AveregeMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted");
                    Console.WriteLine($"{ list[i].MathMark},  {list[i].ChhemistryMark},  {list[i].PhysicsMark}");
                }
            }
        }
    }
}