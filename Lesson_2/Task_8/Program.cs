namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double add = 1;
            for (int i = 1; i <= n; i++)
                sum += Math.Pow((-1), (i + 1)) * (add += 0.1);
            Console.WriteLine($"Sum of numbers: {sum:f1}");
        }
    }
}