using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Kolpakova
{
    class StudentsList
    {
        public string _name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemistryMark;
        public string Name { get => _name; set => _name = value; }
        public double MathMark { get => _mathMark; set => _mathMark = CheckNoMore5(value); }
        public double PhysicsMark { get => _physicsMark; set => _physicsMark = CheckNoMore5(value); }
        public double ChemistryMark { get => _chemistryMark; set => _chemistryMark = CheckNoMore5(value); }
       
        public StudentsList(string name, double math, double physics, double chemistry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemistry;
        }
        double CheckNoMore5(double value)
        {
            if(value > 5)
            {
                return 5;
            }
            else
            {
                return value;
            }
        }
        public int CompareTo(object obj)
        {
            if (obj is StudentsList a)
            {
                return this.Name.CompareTo(a.Name);
            }
            else
                throw new Exception("not students");
        }
    }

    class StudentSelection
    {
        static void Selection(StudentsList[] list, double AverageMark)
        {
            Array.Sort(list);
            int index = 1;
            for (int i = 0; i < list.Length; i++)
            {
                string strIndex = index > 1 ? $"{index}" : "";
                if((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >= AverageMark)
                {
                    Console.WriteLine($"Студент под именем {list[i]._name} допущен к экзамену");
                }
                else
                {
                    Console.WriteLine($"Студент под именем {list[i]._name} не допущен к экзамену");
                }
                if (i + 1 < list.Length)
                {
                    if (list[i].Name == list [i + 1].Name)
                    {
                        index++;
                    }
                    else
                    {
                        index = 1;
                    }
                }

            }
        }

        internal static void Selection(StudentsList[] studentsLists, int v)
        {
            throw new NotImplementedException();
        }
    }
}
