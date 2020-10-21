using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ippolitova
{
    class SL
    {
        public static void StL()
        {
            Console.WriteLine("Введите среднюю оценку");
            double AveregeMark = Convert.ToDouble(Console.ReadLine());
            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Sasha", 6, 1, 7);
            list[1] = new StudentsList("Valya", 6, 1, 5);
            list[2] = new StudentsList("Misha", 1, 4, 5);
            list[3] = new StudentsList("", 5, 5, 5);
            list[4] = new StudentsList("", 3, 2, 10);
            StudentSelection.Selection(list, AveregeMark);
        }
    }
    class StudentsList
    {

        public string _name;
        private double _mathMark;
        private double _physicsMark;
        private double _chemistryMark;

        public StudentsList(string name, double math, double chemistry, double physics)
        {
            _name = name;

            _mathMark = math;
            MathMark = _mathMark;
            _chemistryMark = chemistry;
            ChemistryMark = _chemistryMark;
            _physicsMark = physics;
            PhysicsMark = _physicsMark;
        }
        /*
  
        public string Name
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
    class StudentSelection
    {
        public static void Selection(StudentsList[] list, double AveregeMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].MathMark + list[i].ChemistryMark + list[i].PhysicsMark / 3 >= AveregeMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted");
                    Console.WriteLine($"{ list[i].MathMark},  {list[i].ChemistryMark},  {list[i].PhysicsMark}");
                }
            }
        }
    }
}
