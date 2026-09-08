using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_2
{
    internal class Selector
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Оберіть завдання:");
                Console.WriteLine("1 - Високосний рік");
                Console.WriteLine("2 - Піраміда");
                Console.WriteLine("3 - Хто хоче бути міліонером");
                Console.WriteLine("4 - Поки без логіки");

                Console.WriteLine("");
                Console.Write("Ваш вибір: ");
                string? choice = Console.ReadLine();

                if (choice == null)
                {
                    Console.WriteLine("Ви не зробили вибір.");
                    return;
                }
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Leap_year.Run();
                        break;

                    case "2":
                        Console.WriteLine("");
                        Pyramid.Run();
                        break;

                    case "3":
                        Console.WriteLine("");
                        WhoWantsToBeMillionaire.Run();
                        break;

                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("Поки без логіки");
                        break;

                    default:
                        Console.WriteLine("Невірний вибір.");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
