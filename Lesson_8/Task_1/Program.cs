﻿using System.Text.RegularExpressions;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b\d{2}\.\d{2}\.\d{4}\b");

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Найденные даты:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}