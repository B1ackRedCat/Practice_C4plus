namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt";
            string outputFileOne = "output1.txt";
            string outputFileTwo = "output2.txt";

            string[] lines = File.ReadAllLines(inputFile);
            for (int i = 1; i < lines.Length + 1; i++)
            {
                if (i % 2 == 0)
                {
                    File.AppendAllText(outputFileOne, $"{lines[i - 1]}\n");
                }
                else if (i % 2 == 1)
                {
                    File.AppendAllText(outputFileTwo, $"{lines[i - 1]}\n");
                }
            }
            Console.WriteLine("Done");
        }
    }
}