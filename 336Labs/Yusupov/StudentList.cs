﻿using System;
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

       
        

        public StudentList(String _NameOfStudent, double _GeometryMark, double _AlgebraMark, double _RussianLanguageMark, double _ProgrammingMark  )
        {
            _NameOfStudent = _NameOfStudent;
            _GeometryMark = _GeometryMark;
            _AlgebraMark = _AlgebraMark;
            _RussianLanguageMark = _RussianLanguageMark;
            _ProgrammingMark = _ProgrammingMark; 

        } 
        class List
        {
         public static  void Method (StudentList[] lists , double AveregeMark )
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i]._GeometryMark + lists[i]._AlgebraMark + lists[i]._ProgrammingMark + lists[i]._RussianLanguageMark/4 >=AveregeMark)
                    {
                        Console.WriteLine($"{lists[i]._NameOfStudent} ");
                    }
                }
            }
        }
    }
}
