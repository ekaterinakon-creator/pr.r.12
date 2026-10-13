//**************************************************************************
//* Практическая работа #12                                                *
//* Выполнил: Кондратюк Е.С., группа 2-ИСП                                  *
//* Задание: Организация и использование функций                           *
//**************************************************************************
using System;
namespace Pr.r._12
{
    internal class Program
    { 
        static void Words(int [ ] words = null, int count = 0)
        {
            for (int n = 0;n < count; n++)
            {
                for (int i = 0; i < words.GetLength (0); i++)
                {

                }
            }
            return;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Практическая работа №12";
            Console.WriteLine("Здравствуйте!");
            Console.Write($"Введите количество слов, которое хотите написать: ");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write($"Введите слова через пробел: ");
            int words = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"У вас получилось: {Words}");


        }
    }
}
