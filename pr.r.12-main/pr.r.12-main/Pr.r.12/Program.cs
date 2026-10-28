//**************************************************************************
//* Практическая работа #12                                                *
//* Выполнил: Кондратюк Е.С., группа 2-ИСП                                  *
//* Задание: Организация и использование функций                           *
//**************************************************************************
using System;
namespace Pr_r_12
{
    internal class Program
    {
        static string[] Words(string text) // Функция разбивает введенный текст на отдельные слова
        {
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); // Делим строку по пробелам и удаляем лишние пробелы
            return words;
        }

        static string Result(string[] words, int count) // Функция удаляет слова заданной длины
        {
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != count) // Если длина текущего слова не равна той, что удаляем
                    result += words[i] + " "; // Добавляем текущ слово к итоговой строке и ставим пробел
            }
            result = result.Trim(); // Удаляет лишний пробел в конце
            return result;
        }
        static void HandleError(Exception ex) // Обработка всех ошибок
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nОшибка: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Title = "Практическая работа №12";
                    Console.WriteLine("Здравствуйте!");
                    Console.Write($"Введите слова через пробел: ");
                    string text = Console.ReadLine();
                    Console.Write("Слова какой длины вы хотите убрать из строки? (введите число): ");
                    int count = Int32.Parse(Console.ReadLine());
                    string[] words1 = Words(text); // Вызываем функцию
                    string result1 = Result(words1, count); // Вызываем функцию
                    Console.WriteLine($"У вас получилось: {result1}");
                    bool rightchoice = false; // Флаг
                    while (!rightchoice)
                    {
                        try
                        {
                            Console.Write("Вы хотите повторить программу? (1 - да, 0 - нет): ");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    return;
                                case 1:
                                    rightchoice = true;
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Вы ввели не то число! Попробуйте снова.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                            }
                        }
                        catch(FormatException fex)
                        {
                            HandleError(fex);
                        }
                        catch (OverflowException oex)
                        {
                            HandleError(oex);
                        }
                    }
                }
                catch (FormatException fex)
                {
                    HandleError(fex);
                }
                catch (OverflowException oex)
                {
                    HandleError(oex);
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }
        
    }
}


