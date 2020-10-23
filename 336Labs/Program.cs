using System;

namespace _336Labs.Sogorin
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();            
            Account[] Table = new Account[10];
            Table[0].spisok("Kuzak", "pvan");
            Table[1].spisok("Kuzap", "uvan");
            Table[2].spisok("Kuzam", "tvan");
            Table[3].spisok("Kuzan", "yvan");
            Table[4].spisok("Kuzab", "evan");
            Table[5].spisok("Kuzac", "qvan");
            Table[6].spisok("Kuzax", "dvan");
            Table[7].spisok("Kuzaz", "gvan");
            Table[8].spisok("Kuzal", "jvan");
            Table[9].spisok("Kuzaj", "avan");
            account.shinfo(1);
        }        
    }   
}
