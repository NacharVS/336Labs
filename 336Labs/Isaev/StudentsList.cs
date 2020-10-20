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
            list[0] = new StudentsList("kukumber", 3, 4, 5);
            list[1] = new StudentsList("chelentano", 4, 3, 5);
            list[2] = new StudentsList("german", 3, 4, 5);
            list[3] = new StudentsList("nastya", 5, 5, 5);
            list[4] = new StudentsList("Valentin", 4, 2, 3);
            StudentSelection.Selection(list, AveregeMark);
        }
    }
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
    class StudentSelection
    {
        public static void Selection(StudentsList[] list, double AveregeMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >= AveregeMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted");
                }
            }
        }
    }
}