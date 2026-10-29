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
        static string[] Words(string text)
        {
            string[] words = text.Split(new char[] { ' ' });
            return words;
        }
        static string Result(string[] words, int count)
        {
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != count)
                    result += words[i] + " ";
            }
            result = result.Trim();
            return result;
        }
        static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ошибка: " + ex.Message);
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
                    if (string.IsNullOrWhiteSpace(text))
                    {
                        throw new Exception("вы ничего не ввели. Попробуйте снова.");
                    }
                    Console.Write("Слова какой длины вы хотите убрать из строки? (введите число): ");
                    int count = Int32.Parse(Console.ReadLine());
                    string[] words1 = Words(text); // Вызываем функцию
                    string result1 = Result(words1, count);
                    Console.Write($"У вас получилось: {result1}");
                    bool rightchoice = false;
                    while (!rightchoice)
                    {
                        try
                        {
                            Console.Write("\nВы хотите повторить программу? (1 - да, 0 - нет): ");
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
                                    Console.Write("Вы ввели не то число! Попробуйте снова.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
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
                    }
                }
                catch (ArgumentNullException anex)
                {
                    HandleError(anex);
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


