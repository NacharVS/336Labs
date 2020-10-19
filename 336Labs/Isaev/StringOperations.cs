using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Loginov
{
    class StringOperations
    {
        public static void StrOpr()
        {
            Console.WriteLine("Введите строку");
            string _string = Console.ReadLine();
            string _evenLetters = "";
            string _oddLetters = "";
            Console.WriteLine(_string);
            while (_string != "")
            {
                _oddLetters = _oddLetters + _string.Substring(0, 1);
                _string = _string.Remove(0, 1);
                if (_string != "")
                {
                    _evenLetters = _evenLetters + _string.Substring(0, 1);
                    _string = _string.Remove(0, 1);
                }
            }
            Console.WriteLine(_evenLetters);
            Console.WriteLine(_oddLetters);
        }


    }
}