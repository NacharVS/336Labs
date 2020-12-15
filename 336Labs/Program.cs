using System;
using System.Collections.Generic;

namespace _336Labs.Sogorin
{
    class Program
    {
        private delegate void Trainee(int[] mass);
        private delegate void Tramass(int[] mass, int[] mass2);
       
        static void Main(string[] args)
        {
            /*
            List<String> IdLis = new List<String>();
            List<Account> AccLis = new List<Account>();
            Account acc = new Account();
            AccLis.Add(new Account("Kuzak", "pvan", 89845563326, "1998, 12, 31", 17201));
            AccLis.Add(new Account("Kuzap", "uvan", 89842587953, "1996, 10, 15", 4245));
            AccLis.Add(new Account("Kuzam", "tvan", 89845535697, "1987, 06, 24", 78782));
            AccLis.Add(new Account("Kuzan", "yvan", 89845256776, "1992, 09, 19", 2982));
            AccLis.Add(new Account("Kuzab", "evan", 89845526875, "1988, 01, 30", 78354));
            acc.Bank(AccLis, IdLis, acc);   
            */
            Dictionary<string, string> List = new Dictionary<string, string>();
            Slova sl = new Slova();
            sl.AddN("petr", List);
            sl.AddN("ivan", List);
            sl.AddN("den", List);
            sl.AddN("boris", List);
            sl.shId(List);
            sl.change(List);
            sl.shId(List);
        }        
    }   
}
