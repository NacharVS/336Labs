using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{    
    class Slova
    {
        private string _name;        
        private string s_id;
        public void AddN(string nam, Dictionary<string, string> List)
        {
            Random rnd = new Random();

            nam = nam.Trim();
            var firstLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;

            s_id = rnd.Next(0, 9999).ToString("D4");
            List.Add(s_id, _name);
        }
        public void shId(Dictionary<string, string> List)
        {
            foreach (var item in List)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        public void change(Dictionary<string, string> List)
        {
            Console.Write("Введите id: ");
            string i = Console.ReadLine();
            foreach (var item in List)
            {
                if (item.Key == i)
                {
                    Console.Write("Введите имя: ");
                    string na = Console.ReadLine();
                    na = na.Trim();
                    var firstLet = na[0];
                    var lastLet = na.Remove(0, 1);
                    List[i] = firstLet.ToString().ToUpper() + lastLet;
                    break;
                }
            }
        }
    }
}
