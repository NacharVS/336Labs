using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    public class StudentsList
    {
        public string _name;
        public double _MathMa;
        public double _RussMa;
        public double _phisMa;
        public StudentsList(string name, double math, double rus, double phis)
        {
            _name = name;
            _MathMa = math;
            _RussMa = rus;
            _phisMa = phis;
        }
    }
    public class Stsel
    {
        public static void Sel(StudentsList[] list, double Avma)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._MathMa + list[i]._phisMa + list[i]._RussMa) / 3 >= Avma)
                {
                    Console.WriteLine($"{list[i]} is sucssefull");
                }
            }
        }
    }
    public class Person
    {


        private string _Name;
        private int _Age;

        public Person(string Name, int Age)
        {
            _Name = Name;
            _Age = Age;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {                
                if (_Age < 2)
                {
                    _Age = 2;
                }
                if (_Age > 5 )
                {
                    _Age = 5;
                }
                _Age = value;
            }
        }

    }
}




/*
 *    StudentsList[] list = new StudentsList[5];
            list[0] = new StudentsList("Ivan", 5, 5, 5);
            list[0] = new StudentsList("Frank", 5, 4, 4);
            list[0] = new StudentsList("Jop", 5, 5, 4);
            list[0] = new StudentsList("Inga", 5, 3, 5);
            list[0] = new StudentsList("Rev", 3, 5, 4);
            Stsel.Sel(list, 4.0);
 */