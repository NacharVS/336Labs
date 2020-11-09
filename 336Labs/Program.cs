using System;

namespace _336Labs.Sogorin
{
    class Program
    {
        private delegate void Trainee(string mes);

        static void Main(string[] args)
        {
            Account account = new Account();
            account.shinfo(1);
            Trainee tr1;
            tr1 = Deligate.firstless;
            tr1("Branch");
        }        
    }   
}
