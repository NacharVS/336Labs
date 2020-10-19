using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Dolgov
{
    class StringOperations
    {
        public static void StringOperationss()
        {
            Console.WriteLine("Напишите строку");
            string st = Console.ReadLine();
            string ev = "";
            string od = "";
            Console.WriteLine(st);
                while (st != "")
            {
                od = od + st.Substring(0, 1);
                st = st.Remove(0, 1);
                if (st != "")
                {
                    ev = ev + st.Substring(0, 1);
                    st = st.Remove(0, 1);
                }
            }
            Console.WriteLine(od);
            Console.WriteLine(ev);
        }
    }
}
