using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Sogorin
{
    class Account
    {
        private static double _rate;
        public double _cash;
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
            _cash = cash;
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

        public void Stav(List<Account> AccLis)
        {

        }

        public void Bank(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            acc.Id(AccLis, IdLis);
            acc.Data(AccLis);
            Console.Write("1 - Добавить аккаунт" + "\n" +
                "2 - Авторизация" + "\n" +
                "3 - Информация" + "\n" +
                "4 - ставка" + "\n" +
                "5 - Выход" + "\n" +
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
                        acc.Aut(AccLis, IdLis, acc);
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        acc.shinfo(AccLis);
                        string i = Console.ReadLine();
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 4:
                    {
                        acc.Stav(AccLis);
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 5:
                    {
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

        public void Aut(List<Account> AccLis, List<String> IdLis, Account acc)
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
                                //sw между функциями
                                acc.Aut2(AccLis, IdLis, it);
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

        public void Aut2(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            Console.WriteLine($"Вы вошли под {acc._surname}");
            Console.Write("1 - Изменить данные" + "\n" +
                "2 - Информация" + "\n" +
                "3 - Счет" + "\n" +
                "4 - Выход" + "\n" +
                "Введите №: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1:
                    {
                        acc.Change(AccLis, IdLis, acc);
                        acc.Aut2(AccLis, IdLis, acc);
                        break;
                    }
                case 2:
                    {
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        acc.Cash(AccLis, IdLis, acc);
                        acc.Aut2(AccLis, IdLis, acc);
                        break;
                    }
                case 4:
                    {
                        acc.Bank(AccLis, IdLis, acc);
                        break;
                    }
                case 5:
                    break;
                default:
                    return;
            }
        }

        public void Cash(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            acc.Ca2(AccLis, IdLis, acc);
        }

        public void Ca2(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            Console.WriteLine("1 - Пополнить счет" + "\n" +
                "2 - Снять наличные" + "\n" +
                "3 - Выход");
            Console.Write("Введите №: ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.Write("Ведите сумму: ");
                        acc._cash += double.Parse(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.Write("Ведите сумму: ");
                        double n = double.Parse(Console.ReadLine());
                        if (n > acc._cash)
                        {
                            Console.WriteLine("Сумма превышает ваш баланс" + "\n" +
                                "Желаете продолжить?" + "\n" +
                                "y - Да, n - Нет" + "\n");
                            string fe = Console.ReadLine();
                            if (fe == "y")
                            {
                                acc.Ca2(AccLis, IdLis, acc);
                            }
                            else
                            {
                                acc.Cash(AccLis, IdLis, acc);
                            }
                        }
                        else
                            acc._cash -= n;
                        break;
                    }
                case 3:
                    {
                        acc.Aut2(AccLis, IdLis, acc);
                        break;
                    }
                default:
                    Console.WriteLine("не верный номер!" + "\n" +
                       "Желаете продолжить?" + "\n" +
                       "y - Да, n - Нет" + "\n");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        acc.Cash(AccLis, IdLis, acc);
                    }
                    else
                    {
                        acc.Aut2(AccLis, IdLis, acc);
                    }
                    break;
            }
        }

        public void Info(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            Console.WriteLine("1 - Общая информация" + "\n" +                
                "2 - Возраст клиента" + "\n" +
                "3 - Счет клиента" + "\n" +
                "4 - Выход");

            Console.Write("Введите №: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1:
                    {
                        acc.shinfoac(acc);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 2:
                    {
                        acc.Getold(acc);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        acc.shCash(acc);
                        string i = Console.ReadLine();
                        acc.Info(AccLis, IdLis, acc);
                        break;
                    }
                case 4:
                    {
                        acc.Aut2(AccLis, IdLis, acc);
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
                        acc.Aut2(AccLis, IdLis, acc);
                    }
                    break;
            }
        }

        public void Change(List<Account> AccLis, List<String> IdLis, Account acc)
        {
            Console.Clear();
            acc.ch2(AccLis, IdLis, acc);            
        }

        public void ch2(List<Account> AccLis, List<String> IdLis, Account acc)
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
                        acc.ch2(AccLis, IdLis, acc);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите новое имя:");
                        acc._name = Console.ReadLine();
                        acc.ch2(AccLis, IdLis, acc);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите новый телефон:");
                        acc._phone = long.Parse(Console.ReadLine());
                        acc.ch2(AccLis, IdLis, acc);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введите новую дату:");
                        acc._date = DateTime.Parse(Console.ReadLine());
                        acc.ch2(AccLis, IdLis, acc);
                        break;
                    }
                case 5:
                    {
                        acc.Aut2(AccLis, IdLis, acc);
                        break;
                    }
                default:
                    Console.WriteLine("не верный номер!" + "\n" +
                        "Желаете продолжить?" + "\n" +
                        "y - Да, n - Нет" + "\n");
                    string f = Console.ReadLine();
                    if (f == "y")
                    {
                        acc.ch2(AccLis, IdLis, acc);
                        return;
                    }
                    else
                        acc.Aut2(AccLis, IdLis, acc);
                    break;
            }
        }

        public void shid(List<Account> AccLis, List<String> IdLis)
        {
            Console.Clear();
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
                Console.WriteLine($"{item._surname} {item._name} {item._date.ToShortDateString()} {item._phone}");
            }
        }

        public void shinfoac(Account acc)
        {
            Console.Clear();
            Console.WriteLine($"{acc._surname} {acc._name} {acc._date.ToShortDateString()} {acc._phone}");
        }

        public void shCash(Account acc)
        {
            Console.Clear();
            Console.WriteLine(acc._cash);
        }

        public void Getold(Account acc)
        {
            Console.Clear();
            Console.WriteLine($"{acc._surname} {acc._name} {acc._old}");
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
