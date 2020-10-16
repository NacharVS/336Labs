using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Farkhutdinov
{
    class StudentsList
    {
        public string _namestudent;
        public double _historyMark;
        public double _mathMark;
        public double _mdk0102Mark;
        public double _mdk0103Mark;
        public StudentsList(string namestudent, double historyMark, double mathMark, double mdk0102Mark, double mdk0103Mark)
        {
            _namestudent = namestudent;
            _mathMark = mathMark;
            _historyMark = historyMark;
            _mdk0102Mark = mdk0102Mark;
            _mdk0103Mark = mdk0103Mark;

        }
        class StudentMethod
        {
            public static void Method(StudentsList[] list, double AveregeMark)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if ((list[i]._historyMark + list[i]._mathMark + list[i]._mdk0102Mark + list[i]._mdk0103Mark) / 4 >= AveregeMark)
                    {
                        Console.WriteLine($"{ list[i]._namestudent} допущен");
                    }
                }
            }
        }
    }
}














