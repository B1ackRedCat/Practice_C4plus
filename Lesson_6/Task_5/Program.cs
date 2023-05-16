namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the n: ");
            int n = int.Parse(Console.ReadLine());
            double rez = 2 / f(n);
            Console.WriteLine($"2 / {n}! = {rez:f2}");
        }

        static double f(int n)
        {
            if (n == 1)
                return 1;
            return n * f(n - 1);
        }
    }
}