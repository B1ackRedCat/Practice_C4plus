namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = Math.Exp(2 * x) - Math.Exp(Math.Sqrt(Math.Abs(1 - x))) + 2 * Math.Pow(Math.Sin(x), 2) / Math.PI * Math.Pow(x, 2);
            Console.WriteLine($"y = {y:f4}; x = {x}");
        }
    }
}