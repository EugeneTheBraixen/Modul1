using System;
using System.Globalization;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();

            if (ContainsCommaOrDot(input))
            {
                Console.WriteLine("Ошибка! Введите целое число без запятой или точки.");
            }
            else if (double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double number))
            {
                if (Math.Abs(number % 1) < double.Epsilon)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Введенное число четное");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число нечетное");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! К дробным числам не применяется четность и нечетность");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введенное значение не является числом");
            }
            Console.ReadLine();
        }

        static bool ContainsCommaOrDot(string input)
        {
            return input.Contains(".") || input.Contains(",");
        }
    }
}
