using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace _336Labs.Galimzyanov
{
    class Studentslist
    {
        public string _name;
        private double _mathMark;
        private double _physicsMark;
        private double _chemistryMark;

        public double _MathMark
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
        public double _PhysicsMark
        {
            get
            {
                return _physicsMark;
            }
            set
            {
                if (value < 6 && value > 1)
                {
                    this._physicsMark = value;
                }
                else
                {
                    if (value > 5)

                    {
                        this._physicsMark = 5;
                    }
                    else
                    {
                        this._physicsMark = 2;
                    }
                }
            }
        }
        public double _ChemistryMark
        {
            get
            {
                return _chemistryMark;
            }
            set
            {
                if (value < 6 && value > 1)
                {
                    this._chemistryMark = value;
                }
                else
                {
                    if (value > 5)
                    {
                        this._chemistryMark = 5;
                    }
                    else
                    {
                        this._chemistryMark = 2;
                    }

                }
                
                    
            }

        }
       


        public Studentslist(string name, double math, double physics, double chemistry)
        {
            _name = name;
            _MathMark = math;
            _PhysicsMark = physics;
            _ChemistryMark = chemistry;
        }
    }
    class StudentSelection
    {
        public static void Selection(Studentslist []list, double AverageMark)
        {
            Arr.Sortirovka(list);
            int Ind = 1;
            for(int i = 0; i < list.Length; i++)
            {
                string stringInd = Ind > 1 $"(Ind)" : "";
            }
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._MathMark + list[i]._PhysicsMark + list[i]._ChemistryMark) / 3 >= AverageMark)
                {
                    Console.WriteLine($"Студент под именем {list[i]._name} допущен к экзамену");
                }
                else
                {
                    Console.WriteLine($"Студент под именем {list[i]._name} не допущен к экзамену");
             
                }

                if (i + 1 < list.Length)
                {
                    if (list[i]._name == list[i+1]._name)
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

