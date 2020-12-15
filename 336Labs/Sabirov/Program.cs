using System;

namespace _336Labs.Sabirov
{
    class Program
    {
        static void Main(string[] args)
        {
            StudetsLists[] lists = new StudetsLists[5];
            lists[0] = new StudetsLists("Ivan", 3, 3, 4);
            lists[0] = new StudetsLists("Nastya", 5, 5, 5);
            lists[0] = new StudetsLists("Masha", 2, 3, 4);
            lists[0] = new StudetsLists("Bulat", 3, 2, 5);
            lists[0] = new StudetsLists("Danil", 4, 3, 4);








        }
    }
    static double Average(double math, double physics, double chemistry)
    {

    }
    static void WORLD(String[] args)
    {
        Dictionary<string, string> countries = new Dictionary<string, string>
        {
           {"Франция", "Париж"},
           {"Германия", "Берлин"},
           {"Великобритания", "Лондон"}
        
        };

        foreach (var pair in countries)
            Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
    }
  


}
