using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _336Labs.Yusupov
{
    class StudentList
    {
        public string _name;
        public double _MathMark;
        public double _PhisMark;
        public double _GeometryMark; 

      

        public StudentList(string name , double MathMark , double PhisMark, double GeometryMark )
        {
            _name = name;
            _MathMark = MathMark;
            _PhisMark = PhisMark;
            _GeometryMark = GeometryMark;
        }

    }
        class List
        {
            internal static void Method(StudentList[] lists, double AveregeMark)
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i]._GeometryMark + lists[i]._GeometryMark + lists[i]._MathMark + lists[i]._PhisMark / 3 >= AveregeMark)
                    
                        Console.WriteLine($"{lists[i]._name} access granted");
                    
                }
            }
        }

    class Person
    {
        StudentList list = new StudentList(); 
    
        
        private double mark = Convert.ToDouble(Console.ReadLine());
        public double Mark
        {
            set
            {
                if(mark > list._GeometryMark) {
                    mark = 5; 
                    Console.WriteLine( mark);
                }
                
            }
            get
            {
                return mark; 
            }
        }
    }
 }



    
