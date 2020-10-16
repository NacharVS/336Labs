using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sabirov
{
    class StudetsLists
    {
        public string _name;
        public double _MathMark;
        public double _physicsMark;
        public double _chemistryMark;

        public StudetsLists(string name, double math, double physics, double chemitry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemitry;
        }
        
      
        
    }
   class StudentSelection
    {
        static void Selection(StudetsLists[] lists , double AvarageMark)
        {
            for (int i = 0; i < lists.Length: i++)
            {
                if ((lists{i}._mathMark + lists{i}.physicsMark + lists{i}._chemistryMark) / 3 >= AvarageMark)
                {

                }
            }
        }
    }
       
}
