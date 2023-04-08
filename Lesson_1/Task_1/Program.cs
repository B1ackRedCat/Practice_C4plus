namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine($"Volume V = {volume:f2}");
        }
    }
}