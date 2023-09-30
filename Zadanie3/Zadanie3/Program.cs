using System;
using System.Text.RegularExpressions;

namespace Zadanie3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string SecondName = Console.ReadLine();
            if (name.All(char.IsLetter) || SecondName.All(char.IsLetter))
            {
                if (Regex.IsMatch(name, @"[а-я]", RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(SecondName, @"[а-я]", RegexOptions.IgnoreCase)) ;
                    {
                        string UpName = char.ToUpper(name[0]) + name.Substring(1);
                        string UpSecondName = char.ToUpper(SecondName[0]) + SecondName.Substring(1);
                        Console.WriteLine($"{UpSecondName} {UpName}");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Введён неправильный элемент. " + "Введите только русские буквы.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Введён неправильный элемент. " + "Введите только буквы.");
                Console.ReadLine();
            }
        }
    }
}