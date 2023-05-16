using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b(\w+)\s\1\b");

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Найденные слова, повторяющиеся два раза подряд:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}