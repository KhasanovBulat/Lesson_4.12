using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12.1");
            BankAccount bankaccount1 = new BankAccount(1, 100, AccountType.Actual);
            BankAccount bankaccount2 = new BankAccount(2, 230, AccountType.Savings);
            BankAccount bankaccount3 = new BankAccount(3, 100, AccountType.Actual);
            bankaccount1.Equals(bankaccount2);
            //bankaccount1 == bankaccount3;
            Console.WriteLine(bankaccount1);
            Console.WriteLine(bankaccount2);
            Console.WriteLine(bankaccount3);

            Console.WriteLine("Задание 12.2");
            Console.WriteLine("Введите числитель первой дроби:");
            int numerator_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            int denominator_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби:");
            int numerator_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби:");
            int denominator_2 = Convert.ToInt32(Console.ReadLine());
            Rationals r1 = new Rationals(numerator_1, denominator_1);
            Rationals r2 = new Rationals(numerator_2, denominator_2);
            Rationals r3 = r1 + r2;
            Console.WriteLine(r3);

            Console.WriteLine("Задание 12.3");
            Console.Write("Введите вещественную часть первого комплексного числа: ");
            int real1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int im1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вещественную часть второго комплексного числа: ");
            int real2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int im2 = Convert.ToInt32(Console.ReadLine());
            Complex c1 = new Complex(real1, im1);
            Complex c2 = new Complex(real1, im2);
            Console.WriteLine("Введенные комплексные числа: ");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("Сложение комплексных чисел:");
            Console.WriteLine(c1 + c2);

            Console.WriteLine("Задание 12.4");
            List<Book> books = new List<Book>
            {
                new Book("Хоббит","Р.Р.Толкин","АСТ"),
                new Book("Анна Каренина", "Л.Н. Толстой", "СЗКЭО"),
                new Book("Мастер и Маргарита","М.А. Булгаков","Русская статья")
            };
            BookContainer BookCont = new BookContainer();
            Console.WriteLine("Введите как осортировать контейнер: имя, автор, издатель");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case ("имя"):
                    Console.WriteLine(BookCont.SortByName());
                    break;
                case ("автор"):
                    Console.WriteLine(BookCont.SortByAuthor());
                    break;
                case ("издатель"):
                    Console.WriteLine(BookCont.SortByPublish());
                    break;
                default:
                    Console.WriteLine("Введите имя, автора или издательство!");
                       break;
            }
        }
    } 
}
