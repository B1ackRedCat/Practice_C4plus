using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b(\w+)\s\1\b");

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Found words repeated twice in a row:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}