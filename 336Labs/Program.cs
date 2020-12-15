using System;
using _336Labs.Acadullin;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> List = new List<BankAccount>();
            BankAccount bank = new BankAccount();

            //List.Add(new BankAccount("Aizat", "Asadullin",  "+79397777777", DateTime.Parse("11.03.98"), 222));
            //List.Add(new BankAccount("Amir", "Galimzaynov",  "+79318888888", DateTime.Parse("2005.06.22"), 888));
            //List.Add(new BankAccount("Azat", "Baiburin", "+79166666666", DateTime.Parse("2003.03.15"), 666));
            //bank.SetFIO(bank);
            //foreach (var item in List)
            //{
            //    Console.WriteLine($"{item.Name} {item.Surname} {item.PhoneNumber} {item.Brithday} {item.Age}");
            //}


            //BankAccount bank = new BankAccount("+79003279046", 5000);
            Console.WriteLine("Введите имя: ");
            bank.SetName(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            bank.SetSurname(Console.ReadLine());
            Console.WriteLine("Ваш ID: ");
            bank.GetId(Console.ReadLine());

            
            //banks.RateChangedEvent += RateMessage;
            //Console.WriteLine($"Ваша ставка: { banks.Rate}");
            //banks.newRate(0.47);
            //Console.WriteLine($"Ваша ставка: { banks.Rate}");
            //Console.WriteLine("Введите свой день рождения.");
            //banks.Age();
            //Console.WriteLine($"Ваш счет: { banks.Sum}");
            //banks.PhoneNumberEvent += MessageSetting;
            //Console.WriteLine("Введите сколько хотите положить на счет?");
            //banks.Polosh(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Ваш счет: { banks.Sum}");
            //Console.WriteLine("Введите сколько хотите снять со счета?");
            //banks.Vzyat(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Ваш счет: { banks.Sum}");

            //banks.RateChangedEvent += RateChangednotify;
            //banks.RateChange(0.38);

            //public static void MessageSending(string Phonenomer)
            //{
            //    Console.WriteLine($"СМС отправлен на номер: {Phonenomer}");
            //}
            //public static void MessageSending2(string Phonenomer)
            //{
            //    Console.WriteLine($"СМС отправлен на номер: {Phonenomer}");
            //}
            //public static void AccountConditition(string phonenumber, int sum)
            //{
            //    Console.WriteLine($"Стоимость счета: {sum}");
            //}
            //public static void RateChangednotify(double oldRate, double newRate)
            //{
            //    Console.WriteLine($"Старая ставка {oldRate} новая ставка {newRate}");
            //}
        }
    }         
}   
            
 
