namespace Task_2
{
    internal class Program
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 3)
            {
                y = Math.Sin(x);
            }
            else if (Math.Abs(x) < 9)
            {
                y = Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5);
            }
            else
            {
                y = Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            }
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            double h = double.Parse(Console.ReadLine());
            double func;
            for (double i = a; i <= b; i += h)
            {
                func = f(i);
                Console.WriteLine($"f({i:f2}) = {func:f4}");
            }
        }
    }
}