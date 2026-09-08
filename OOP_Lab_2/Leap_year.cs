using System.Text;

namespace OOP_Lab_2
{
    internal class Leap_year
    {
        //Розробити програму, яка буде питати у користувача рік, після чого буде відповідати чи високосний це рік
        //Для того щоб рік був високосний, він повинен підтримувати наступні вимоги:

        //кожен 4ий рік - високосний
        //кожен 100ий рік - НЕ високосний
        //кожен 400ий рік - високосний

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;

                Console.Write("Введіть рік: ");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0)
                {
                    Console.WriteLine($"Рік {year} є високосним.");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine($"Рік {year} НЕ є високосним.");
                }
                else if (year % 400 == 0)
                {
                    Console.WriteLine($"Рік {year} є високосним.");
                }
                else
                {
                    Console.WriteLine($"Рік {year} НЕ є високосним.");
                }
                Console.WriteLine("");
            }
        }
    }
}
