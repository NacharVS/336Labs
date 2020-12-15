using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{    
    class Slova
    {
        private string _name;
        private long i_id;
        private string s_id;
        public Slova()
        {

        }
        public Slova(string nam)
        {
            nam = nam.Trim();
            var firstLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;      
        }

        public void Dic(Slova sl)
        {
            Dictionary<string, Slova> List = new Dictionary<string, Slova>();
            Random rnd = new Random();
            foreach (var item in List)
            {
                i_id = rnd.Next(0, 999999);
                s_id = i_id.ToString("D6");
                List.Add(s_id, sl._name);
            }
        }
        

    }
}
