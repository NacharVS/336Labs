using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Ziatdinova
{
    class StudentsList
    {
        public string name;
        public double mathMark;
        public double physicsMark;
        public double chemistryMark;
        
        public string Name { get => name; set => name = value; }
        public double MathMark { get => mathMark; set => mathMark = CheckNoMore5(value); }
        public double PhysicsMark { get => physicsMark; set => physicsMark = CheckNoMore5(value); }
        public double ChemistryMark { get => chemistryMark; set => chemistryMark = CheckNoMore5(value); }
        public StudentsList(string name, double math, double physics, double chemistry)
        {
            Name = name;
            MathMark = math;
            PhysicsMark = physics;
            ChemistryMark = chemistry;
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
                throw new Exception("Не студенты");
        }
    }

    class StudentSelection
    {
        public static void Selection(StudentsList[] list, double AverageMark)
        {
            Array.Sort(list);
            int index = 1;
            for (int i = 0; i < list.Length; i++)
            {
                string strIndex = index > 1 ? $"{index}" : "";
                if ((list[i].MathMark + list[i].PhysicsMark + list[i].ChemistryMark) / 3 >= AverageMark)
                {
                    Console.WriteLine($"{list[i].Name} acces granted");
                }
                else
                {
                    Console.WriteLine($"{ list[i].Name} Not acces granted");

                }
                Console
                if (i + 1 < list.Length)
                {
                    if (list[i].Name == list[i + 1].Name)
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
    }
}

