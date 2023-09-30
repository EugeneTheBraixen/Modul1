using System;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double rad) && rad >= 0)
            {
                double square = Math.PI * Math.Pow(rad, 2);
                Console.WriteLine($"Площадь окружности равна {square}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введенное значение не соответствует условию.");
            }

            Console.ReadLine();
        }
    }
}
