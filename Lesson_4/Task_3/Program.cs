namespace Task_3
{
    internal class Program
    {
        static void f(double x, out double y)
        {
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
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            double h = double.Parse(Console.ReadLine());
            double y;
            for (double i = a; i <= b; i += h)
            {
                f(i, out y);
                Console.WriteLine($"f({i:f2}) = {y:f4}");
            }
        }
    }
}