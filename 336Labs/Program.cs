using System;
using _336Labs.Acadullin;
using System.Collections.Generic;

namespace _336Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentsList> studentList = new List<StudentsList>();

            studentList.Add(new StudentsList("Aizat", 18, 4222));
            studentList.Add(new StudentsList("Amir", 17, 5254));
            studentList.Add(new StudentsList("Azat", 18, 7585));

            EditName(studentList, 5254, "Ainur");

            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }


            //BankAccount banks = new BankAccount("+79003279046", 5000);
            //Console.WriteLine("Введите имя: ");
            //banks.SetName(Console.ReadLine());
            //Console.WriteLine("Введите фамилию: ");
            //banks.SetSurname(Console.ReadLine());
            //Console.WriteLine("Ваш ID: ");
            //banks.SetId();
            //Console.WriteLine(banks.GetID());
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
            
 
