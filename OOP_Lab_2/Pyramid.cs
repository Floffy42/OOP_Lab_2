using System.Text;

namespace OOP_Lab_2
{
    internal class Pyramid
    {
        //Розробити програму що буде питати у користувача висоту трикутника.
        //Наприклад користувач ввів число 4. Програма мати вивести трикутник висоти яку ввів користувач.

        //     1
        //    2 2
        //  3  3  3
        //4  4  4  4

        public static void Run()
        {
            while(true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;

                Console.Write("Введіть висоту трикутника: ");
                int height = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= height; i++)
                {
                    // пропуски
                    for (int j = 0; j < height - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // чмсла
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                }
            }    
        }
    }
}