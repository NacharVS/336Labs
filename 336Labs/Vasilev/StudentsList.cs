using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Vasilev
{
    class StudentList
    {
        public static void StL()
        {
            Console.WriteLine("Введите средний балл");
            double AveregeMark = Convert.ToDouble(Console.ReadLine());
            StudentsList[] list = new StudentsList[6];
            list[0] = new StudentsList("Obi-Wan", 3, 4, 5);
            list[1] = new StudentsList("Anakin Skywalker", 4, 5, 5);
            list[2] = new StudentsList("Luke Skywalker", 3, 4, 5);
            list[3] = new StudentsList("Palpatine", 5, 5, 5);
            list[4] = new StudentsList("Chewbacca", 3, 2, 3);
            list[5] = new StudentsList("Princess Leia ", 4, 4, 5);
            StudentSelection.Selection(list, AveregeMark);
        }
    }
    class StudentsList
    {

        public string _Name;
        public double _mathMark;
        public double _physicsMark;
        public double _chemistryMark;
        public string _Company;


        public StudentsList(string name, double math, double physics, double chemisiry)
        {
            _name = name;
            _mathMark = math;
            _physicsMark = physics;
            _chemistryMark = chemisiry;
        }
    }
    class StudentSelection
    {
        public static void Selection(StudentsList[] list, double AveregeMark)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i]._mathMark + list[i]._physicsMark + list[i]._chemistryMark) / 3 >= AveregeMark)
                {
                    Console.WriteLine($"{list[i]._name} acces granted");
                }
            }
        }
    }
    class Studentcompany
    {
        private string Company;
        private string newCompanyName;
        public string _Company;
        public string _Name;
        public string nejopa
    {
            set
            {
                newCompanyName = newCompanyName.Trim();
                var firstLetter = newCompanyName[0];
                var otherLetters = newCompanyName.Remove(0, 1);
            }
    }
    public void ShowCompanyName()
    {
        Console.WriteLine(_Company);
    }

    public void Showinfo()
    {
        Console.WriteLine($"Student: {_Name} in {_Company}");
    }

}



    class chtoto2
    {
        private object return_name;

        public string Name
        {
            get
            {
                object return_name1 = return_name;

            }
        }
    }
          
    class chtoto
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.SetName("Palpatine");
            stud.SetCompanyName("Empire");
            stud.ShowName();
            ShowCompanyName();
            Console.WriteLine();
            stud.ShowInfo();

        }
    }
}