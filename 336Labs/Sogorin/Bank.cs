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
        public long _id;
        int _old;
        DateTime Date;
        public Account()
        {

        }
        public void Id(List<Account> AccLis, List<BankAcc> IdLis)
        {
            Random rnd = new Random();

            foreach (Account item in AccLis)
            {                
                _id = rnd.Next(0, 999999);
                int id = int.Parse(_id.ToString("D6"));
                IdLis.Add(new BankAcc(id));
                Console.WriteLine($"{item} {id}");
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

            Date = DateTime.Parse(data);
        }
        public void Change(List<Account> AccLis, List<BankAcc> IdLis)
        {
            foreach (var item in AccLis)
            {
                Console.WriteLine(item);
            }           

            Console.Write("Введите ваш индекс: ");
            int ind = int.Parse(Console.ReadLine());
            if ((IdLis.Contains(new BankAcc(ind))) == true)
            {
                //Переход к листу с акаунтами для изменения(синхрон 1 и 2 листа)

                foreach (Account item in AccLis)
                {
                    if (AccLis.IndexOf(item) == IdLis.IndexOf(new BankAcc(ind)))
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
                                    _surname = Console.ReadLine();
                                    break;
                                }
                            case 2:
                                {
                                    _name = Console.ReadLine();
                                    break;
                                }
                            case 3:
                                {
                                    _phone = long.Parse(Console.ReadLine());
                                    break;
                                }
                            case 4:
                                {
                                    Date = DateTime.Parse(Console.ReadLine());
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
                }
            }
        }
        public void shinfo(int id)
        {
            List<Account> AccLis = new List<Account>();
            foreach (var item in AccLis)
            {
                Console.WriteLine(item);
            }
            AccLis.GetRange(id, 0);
        }
        public void Getold()
        {
            //DateTime;
        }
    }
    class BankAcc
    {
        private int _sum;
        public int _id;
        public string Notify = "Massage ";
        public BankAcc(int id)
        {
            _id = id;
        }
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
        public void Getid()
        {

        }
    }
}
