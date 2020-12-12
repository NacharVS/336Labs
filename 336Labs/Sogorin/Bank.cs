using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Account
    {
        private static double _rate;
        private double _paymentac;
        public string _name;
        public string _surname;
        public long _phone;
        public int i_id;
        public string s_id;
        int _old;
        DateTime Date;
        public Account()
        {

        }
        public void Id(List<Account> AccLis, List<String> IdLis)
        {
            Random rnd = new Random();

            foreach (Account item in AccLis)
            {                
                i_id = rnd.Next(0, 999999);
                s_id = i_id.ToString("D6");
                IdLis.Add(new string(s_id));
                Console.WriteLine($"{item._surname} {item._name} {s_id}");
            }
        }
        public Account(string sur, string nam, long pho, string data)
        {
            _surname = sur;
            sur = sur.Trim();
            var firstLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _surname = firstLet1.ToString().ToUpper() + lastLet1;

            _name = nam;
            nam = nam.Trim();
            var firstLet = nam[0];
            var lastLet = nam.Remove(0, 1);
            _name = firstLet.ToString().ToUpper() + lastLet;

            if ((pho / 10 ^ 10) > 1)
            {
                _phone = pho;
            }
            else
            {
                Console.WriteLine("Измените номер");
            }

            Date = DateTime.Parse(data);
        }


        public void Change(List<Account> AccLis, List<String> IdLis)
        {       
            Console.Write("Введите ваш индекс: ");
            string ind = Console.ReadLine();
            Account acc = new Account();
            //Проверка на наличие id-ка
            if ((IdLis.Contains(new String(ind))) == true)
            {                
                Console.WriteLine("Нашёл");
                //ind сравниваем с coun IdLis и coun index.IdLis == index.AccLis
                foreach (var item in IdLis)
                {
                    if (ind == item)
                    {
                        int i = IdLis.IndexOf(item);
                        foreach (var it in AccLis)
                        {
                            if (i == AccLis.IndexOf(it))
                            {
                                acc.ch2(it);
                                Console.WriteLine("Изменения успешно внесены");
                            }
                        }
                    }
                }
            }
        }
        public void ch2(Account it)
        {
            Console.WriteLine("1 - Изменить Фамилию");
            Console.WriteLine("2 - Изменить Имя");
            Console.WriteLine("3 - Изменить Номер");
            Console.WriteLine("4 - Изменить Дату рождения");
            Console.Write("Введите №: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Введите новую фамилию");
                        it._surname = Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите новое имя");
                        it._name = Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите новый телефон");
                        it._phone = long.Parse(Console.ReadLine());
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введите новую дату");
                        it.Date = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                default:
                    Console.WriteLine("Не верный номер");
                    Console.WriteLine("Желаете продолжить?");
                    Console.WriteLine("y - Да, n - Нет");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        return;
                    }
                    else
                        break;
            }
        }

        public void shinfo(List<Account> AccLis)
        {            
            foreach (var item in AccLis)
            {
                Console.WriteLine($"{item._surname} {item._name} {s_id}");
            }            
        }
        public void Getold()
        {
            //DateTime;
        }
    }
    class BankAcc
    {
        private int _sum;
        public string Notify = "Massage ";       
        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
                //Notify?.Invoke(Phonnum);
            }
        }
    }
}
