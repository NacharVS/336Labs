using _336Labs.Yusupov;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList[] list = new StudentList[5];
            list[0] = new StudentList("Ainur", 5, 4, 3, 4); 
            list[1] = new StudentList("Amir", 2,2,2,2);
            list[2] = new StudentList("Andrey", 3, 3, 3, 4);
            list[3] = new StudentList("Bulat", 2, 3, 4, 4);
            list[4] = new StudentList("Nail", 5, 5, 5, 5);

            double AveregeMark = 4.1;
            List.Method(list, AveregeMark); 
        }
    }
}
