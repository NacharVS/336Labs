using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Yusupov
{
    class StudentList
    {
        public string _NameOfStudent;
        public double _GeometryMark;
        public double _AlgebraMark;
        public double _RussianLanguageMark;
        public double _ProgrammingMark;
      

        public StudentList(string NameOfStudent, int GeometryMark , int AlgebraMark, int RussianLanguageMark ,int ProgrammingMark)
        {
            _NameOfStudent = NameOfStudent;
            _GeometryMark = GeometryMark;
            _AlgebraMark = AlgebraMark;
            _RussianLanguageMark = RussianLanguageMark;
            _ProgrammingMark = ProgrammingMark; 
        }

        public StudentList(string NameOfStudent, double GeometryMark, double AlgebraMark, double RussianLanguageMark, double ProgrammingMark)
        {
            _NameOfStudent = NameOfStudent;
            _GeometryMark = GeometryMark;
            _AlgebraMark = AlgebraMark;
            _RussianLanguageMark = RussianLanguageMark;
            _ProgrammingMark = ProgrammingMark;
        }
    }
        class List
        {
            internal static void Method(StudentList[] lists, double AveregeMark)
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i]._GeometryMark + lists[i]._AlgebraMark + lists[i]._ProgrammingMark + lists[i]._RussianLanguageMark / 4 >= AveregeMark)
                    
                        Console.WriteLine($"{lists[i]._NameOfStudent} access granted");
                    
                }
            }
        }
    }



    
