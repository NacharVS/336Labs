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

            int[] mass1 = new int[4];
            int[] mass2 = new int[4];
            Deligate.mas(mass1, mass2);
            Trainee tr1;
            //tr1 = Deligate.summas;
            tr1 = Deligate.sortmas;
            tr1(mass1);

            Tramass tr2;
            tr2 = Delmass.disdualmas;
            tr2(mass1, mass2);
        }        
    }   
}
