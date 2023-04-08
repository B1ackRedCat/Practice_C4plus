namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle alpha: ");
            double alfa = double.Parse(Console.ReadLine());
            double z1 = (1 - 2 * Math.Pow(Math.Sin(alfa), 2)) / (1 + Math.Sin(2 * alfa));
            double z2 = (1 - Math.Tan(alfa)) / (1 + Math.Tan(alfa));
            Console.WriteLine($"z1 = {z1:f4}");
            Console.WriteLine($"z2 = {z2:f4}");
        }
    }
}