namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three-valued automorphs:");
            for (int i = 100; i <= 999; i++)
                if (Math.Pow(i, 2) % 1000 == i)
                    Console.WriteLine(i);
        }
    }
}