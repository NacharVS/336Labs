using System;

namespace _336Labs.Sogorin
{
    class Program
    {
        private delegate void Trainee(int[] mass);
        private delegate void Tramass(int[] mass, int[] mass2);
       
        static void Main(string[] args)
        {
            //Account account = new Account();
            //account.shinfo(1);
            Account acc = new Account(500, "+7962532421");
            acc.Getid("Kuzak");
            
        }        
    }   
}
