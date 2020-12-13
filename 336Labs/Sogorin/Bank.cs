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
        public int _old;
        public DateTime _date;
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
            }
        }

        public Account(string sur, string nam, long pho, string data, double cash)
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
            _date = DateTime.Parse(data);            
        }

        public void AddAcc(List<Account> AccLis)
        {
            Console.Clear();
            Console.WriteLine("Введите Фамилию:");
            string Sur = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Имя:");
            string Nam = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Номер телефона:");
            long Num = long.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите Дату рождения:");
            string DOB = Console.ReadLine();
            Console.Clear();
            int Cas = 0;            
            AccLis.Add(new Account(Sur, Nam, Num, DOB, Cas));
        }

        public void Data(List<Account> AccLis)
        {
            foreach (var item in AccLis)
            {
                item._old = DateTime.Now.Year - item._date.Year;
            }            
        }

        public void Bank(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            acc.Id(AccLis, IdLis);
            acc.Data(AccLis);
            Console.WriteLine("1 - Добавить аккаунт" + "\n" +
                "2 - Изменить данные" + "\n" +
                "3 - Информация" + "\n" +
                "4 - Счет" + "\n" +
                "5 - ставка" + "\n" +
                "Введите №: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();            
            switch (num)
            {
                case 1:
                    {
                        acc.AddAcc(AccLis);
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 2:
                    {                        
                        acc.Change(AccLis, IdLis, acc);
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        acc.Info(AccLis, IdLis, acc);                        
                        break;
                    }
                case 4:
                    {
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 5:
                    {
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                default:
                    Console.WriteLine("не верный номер!" + "\n" +
                        "Желаете продолжить?" + "\n" +
                        "y - Да, n - Нет" + "\n");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        acc.Bank(AccLis, IdLis, acc);
                    }
                    else
                        return;
                    break;
            }
        }

        public void Info(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            Console.WriteLine("1 - Общая информация" + "\n" +
                "2 - Информацию по id" + "\n" +
                "3 - Возраст всех клиентов" + "\n" +
                "4 - Выход");
            
            Console.Write("Введите №: ");
            int num = int.Parse(Console.ReadLine());           
            Console.Clear();
            switch (num)
            {
                case 1:
                    {
                        acc.shinfo(AccLis);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 2:
                    {
                        acc.shid(AccLis, IdLis);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        acc.Getold(AccLis);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 4:
                    {
                        acc.Bank(AccLis,IdLis,acc);                        
                        break;
                    }
                default:
                    Console.WriteLine("не верный номер!" + "\n" +
                        "Желаете продолжить?" + "\n" +
                        "y - Да, n - Нет" + "\n");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        acc.Info(AccLis, IdLis, acc);
                    }
                    else
                    {
                        acc.Bank(AccLis, IdLis, acc);
                    }                        
                    break;                    
            }
        }

        public void Change(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            acc.shid(AccLis, IdLis);
            Console.Write("Введите ваш индекс: ");
            string ind = Console.ReadLine();
            Console.Clear();
            if ((IdLis.Contains(new String(ind))) == true)
            {
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
                                acc.ch2(it, AccLis, IdLis);
                                Console.WriteLine("Изменения успешно внесены");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("не верный ID!" + "\n" +
                        "Желаете продолжить?" + "\n" +
                        "y - Да, n - Нет" + "\n");
                string f = Console.ReadLine();
                if (f == "y")
                {
                    acc.Change(AccLis, IdLis, acc);
                }
                else
                {
                    acc.Bank(AccLis, IdLis, acc);
                }
            }
        }

        public void ch2(Account acc, List<Account> AccLis, List<String> IdLis)
        {
            Console.Clear();
            Console.WriteLine("1 - Изменить Фамилию" + "\n" +
                "2 - Изменить Имя" + "\n" +
                "3 - Изменить Номер" + "\n" +
                "4 - Изменить Дату рождения" + "\n" +
                "5 - Выход" + "\n" +
                "Введите №: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Введите новую фамилию:");
                        acc._surname = Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите новое имя:");
                        acc._name = Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите новый телефон:");
                        acc._phone = long.Parse(Console.ReadLine());
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введите новую дату:");
                        acc._date = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                case 5:
                    {
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                default:
                    Console.WriteLine("не верный номер!" + "\n" +
                        "Желаете продолжить?" + "\n" +
                        "y - Да, n - Нет" + "\n");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        acc.ch2(acc, AccLis, IdLis);
                        return;
                    }
                    else
                        acc.Bank(AccLis, IdLis, acc);
                    break;
            }
        }

        public void shid(List<Account> AccLis, List<String> IdLis)
        {
            foreach (Account item in AccLis)
            {
                foreach (String it in IdLis)
                {
                    if (AccLis.IndexOf(item) == IdLis.IndexOf(it))
                    {
                        Console.WriteLine($"{item._surname} {item._name} {it}");
                    }
                }                          
            }
        }

        public void shinfo(List<Account> AccLis)
        {
            Console.Clear();
            foreach (var item in AccLis)
            {
                Console.WriteLine($"{item._surname} {item._name} {item._date} {item._phone}");
            }   
        }

        public void Getold(List<Account> AccLis)
        {
            Console.Clear();
            foreach (var item in AccLis)
            {
                Console.WriteLine($"{item._surname} {item._name} {item._old}");
            }            
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
