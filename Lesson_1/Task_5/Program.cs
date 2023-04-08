namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four-digit number: ");
            int num = int.Parse(Console.ReadLine());
            int mult = 1;
            int digit;
            while (num > 0)
            {
                digit = num % 10;
                mult *= digit;
                num /= 10;
            }
            Console.WriteLine($"Product of digits: {mult}");
        }
    }
}