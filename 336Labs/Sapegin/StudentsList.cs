using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sapegin
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
    }


    class StudentSelection
    {

       internal static void Selection(StudentsList[] list, double AverageMark)
        {
            
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >= AverageMark)

                Console.WriteLine($" {list[i]._name} acces granted");

                
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Maksim", 4, 3, 4);
            list[1] = new StudentsList("Ilya", 4, 5, 4);
            list[2] = new StudentsList("Andrey", 5, 5, 4);
            list[3] = new StudentsList("Leonid", 3, 3, 3);
            list[4] = new StudentsList("Vasiliy", 4, 3, 5);
            double AverageMark = 4.35;
            StudentSelection.Selection(list, AverageMark);

        }
    }
}
