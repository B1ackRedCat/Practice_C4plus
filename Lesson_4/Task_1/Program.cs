namespace Task_1
{
    internal class Program
    {
        static double min(double a, double b)
        {
            return (a < b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Enter u: ");
            double u = double.Parse(Console.ReadLine());
            double minNumb = min(min(x, y), min(z, u));
            Console.WriteLine($"Minimum number: {minNumb}");
        }
    }
}