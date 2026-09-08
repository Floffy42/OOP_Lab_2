using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_2
{
    internal class WhoWantsToBeMillionaire
    {
        //Розробити гру "Хто хоче стати міліонером".
        //Програма повина надавати користувачу 4 варіанти відповідей, а користувач повинен обрати одну з них.
        //Після чого программа повинна нараховувати бали за кожну послідовну правильну відповідь.
        //Створити 5 таких питать.

        private static Dictionary<string, (string[], int)> list = new Dictionary<string, (string[], int)>
        {
            {"Які кольори мають бути на прапорі України?", (new string[] { "Червоний і синій", "Жовтий і синій", "Синій і зелений", "Жовтий і блакитний" }, 2) },
            {"В якому місті знаходиться ДТЕУ?", (new string[] { "Київ", "Чернівці", "Львів", "Одеса" }, 1) },
            {"На якій мові написана ця програма?", (new string[] { "C#", "Python", "Java", "JavaScript" }, 1) },
            {"Як називається контрольна робота в університеті по предмету?", (new string[] { "Контрольна робота", "Екзамен", "Курсова робота", "Диплом" }, 2) },
            {"Що зі списку є в ООП?", (new string[] { "Інкапсуляція", "Поліморфізм", "Успадкування", "Всі вищезгадані" }, 4) }
        };
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            var questions = new Dictionary<string, (string[], int)>(list);

            var random = new Random();

            int score = 0;
            while (true)
            {
                if (questions.Count <= 0)
                {
                    GameOver(score);
                    break;
                }

                int indexOfQuestion = random.Next(0, questions.Count);

                Console.WriteLine($"{list.Count - questions.Count + 1}. {questions.Keys.ElementAt(indexOfQuestion)}");
                Console.WriteLine("");

                for (int i = 0; i < questions.Values.ElementAt(indexOfQuestion).Item1.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {questions.Values.ElementAt(indexOfQuestion).Item1[i]}");
                }
                Console.Write("Ваша відповідь: ");

                string? answer = Console.ReadLine();

                if (answer != questions.Values.ElementAt(indexOfQuestion).Item2.ToString())
                {
                    GameOver(score);
                    break;
                }
                else if (questions.Count > 1)
                {
                    score += 100;
                    Console.WriteLine("");
                    Console.WriteLine("Правильно!");
                    Console.WriteLine($"Ваш рахунок: {score}");
                    Console.WriteLine("");
                    questions.Remove(questions.Keys.ElementAt(indexOfQuestion));
                }
                else
                {
                    score += 100;
                    questions.Remove(questions.Keys.ElementAt(indexOfQuestion));
                }
            }
        }
        private static void GameOver(int score)
        {
            Console.WriteLine("");
            Console.WriteLine("Гра завершена!");
            Console.WriteLine($"Ваш рахунок: {score}");
            Console.WriteLine("");
        }
    }
}