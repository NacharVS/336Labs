using _336Labs.Yusupov;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            StudentList[] list = new StudentList[3];
            list[0] = new StudentList("Ainur", 5, 4, 3);
            list[1] = new StudentList("Amir", 4, 4, 4);
            list[2] = new StudentList("Andrey", 3, 3, 5);

            List.Method(list, person.Mark);
        }
    }
}
