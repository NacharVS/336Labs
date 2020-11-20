using _336Labs.Yusupov;
using Interfaces;
using System;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            IWork work1;
            work1 = new Unit1();
            work1.CraftEarth(); 

        }
    }
}
