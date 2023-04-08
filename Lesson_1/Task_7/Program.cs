namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            double h = double.Parse(Console.ReadLine());
            double g = 9.81523;
            double t = Math.Sqrt(2 * h / g);
            Console.WriteLine($"Stone fall time t = {t:f3}");
        }
    }
}