using System;

namespace _336Labs.Bayburin

{
    class program
    {
        static void Main(string[] args)
        {
            StudentsList.Method(new StudentsList[4], 4);
            StudentsList[] list = new StudentsList[4];
            list[0] = new StudentsList ("azat", 5, 3, 5, 5);
            list[1] = new StudentsList("azat", 5, 5, 5, 5);
            list[2] = new StudentsList("ainur", 3, 3, 5, 5);
            list[3] = new StudentsList("ainur", 2, 3, 2, 2);
            list[4] = new StudentsList("amirlox", 3, 2, 2, 5);
            
        }
    }
}

        

    


