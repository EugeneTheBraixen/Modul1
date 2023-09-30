using System;

namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double age) && age >= 0)
            {
                if (age >= 18)
                {
                    Console.WriteLine("Вы можете получить права");
                }
                else
                {
                    Console.WriteLine("Вы не можете получить права");
                }
            }
            else if (age < 0)
            {
                Console.WriteLine("Ошибка! Возраст не может быть отрицательным");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное значение");
            }

            Console.ReadLine();
        }
    }
}
