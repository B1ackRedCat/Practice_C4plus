namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
                Console.WriteLine(i);
            int amountNumb = b - a + 1;
            Console.WriteLine($"Amount of numbers: {amountNumb}");
        }
    }
}