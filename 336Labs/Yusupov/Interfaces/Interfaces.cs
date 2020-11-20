using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IWork 
    {
        public double Work  { get; set;  }
        void CraftEarth(); 
    }
    interface IAttack
    {
        public double Uron { get; set; }
        void Attack(); 
    }

    interface IState
    {
        public double High { get; set; }
        void Bulid(); 
    }
    class Unit1 : IWork
    {
        double IWork.Work { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IWork.CraftEarth()
        {
      
            Console.WriteLine("im unit1 i build this states ");
        }
        class Unit2 : IAttack
        {
            double IAttack.Uron { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            void IAttack.Attack()
            {
                Console.WriteLine("Attack!!! ");
            }
        }
    }
    }

