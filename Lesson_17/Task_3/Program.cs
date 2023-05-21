namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"input.txt";
            string newFilePath1 = @"output1.txt";
            string newFilePath2 = @"output2.txt";

            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();

            int linesCount = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"Number of lines: {linesCount}\n");

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine($"Number of characters per line \"{line}\": {line.Length}");
            }

            string[] newLines = lines.Take(lines.Length - 1).ToArray();
            File.WriteAllLines(newFilePath1, newLines);


            Console.WriteLine();
            int s1 = 2;
            int s2 = 4;
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }

            int maxLength = lines.Max(line => line.Length);
            Console.WriteLine($"\nThe longest string has length {maxLength}");

            Console.Write("\nEnter a letter: ");
            char letter = Char.Parse(Console.ReadLine());
            Console.WriteLine($"Lines starting with a letter {letter}:");
            foreach (string line in lines)
            {
                if (line.StartsWith(letter.ToString()))
                {
                    Console.WriteLine(line);
                }
            }

            string[] reversedLines = lines.Reverse().ToArray();
            File.WriteAllLines(newFilePath2, reversedLines);
        }
    }
}