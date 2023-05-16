namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            int digitCount = 0;
            int nonDigitCount = 0;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    digitCount++;
                else
                    nonDigitCount++;
            }

            Console.WriteLine("Count of numbers: " + digitCount);
            Console.WriteLine("Count of symbols, which not a number: " + nonDigitCount);
        }
    }
}