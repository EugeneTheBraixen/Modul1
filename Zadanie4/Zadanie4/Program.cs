using System;
using System.Text.RegularExpressions;

namespace Zadanie3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Random RandomMassive = new Random();
            int[] massive = new int[20];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = RandomMassive.Next(1, 101);
            }
            int max = massive[0];
            int min = massive[0];
            foreach (int num in massive)
            {
                max = Math.Max(max, num);
                min = Math.Min(min, num);
            }
            Console.WriteLine("Массив случайных чисел:\n" + string.Join(" ", massive));
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.ReadLine();
        }
    }
}
