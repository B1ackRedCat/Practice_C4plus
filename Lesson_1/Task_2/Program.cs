namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a two-digit number: ");
            int numb = int.Parse(Console.ReadLine());
            int firstDig = numb / 10;
            int secondDig = numb % 10;
            int result = firstDig * secondDig;
            Console.WriteLine($"Product of digits: {firstDig} * {secondDig} = {result}");
        }
    }
}