namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double AMean, GMean;
            Mean(a, b, out  AMean, out GMean);
            Console.WriteLine($"for A and B: AMean = {AMean:f2}; GMean = {GMean:f2}");
            Mean(a, c, out AMean, out GMean);
            Console.WriteLine($"for A and C: AMean = {AMean:f2}; GMean = {GMean:f2}");
            Mean(a, d, out AMean, out GMean);
            Console.WriteLine($"for A and D: AMean = {AMean:f2}; GMean = {GMean:f2}");
        }

        static void Mean(double x, double y, out double AMean, out double GMean)
        {
            AMean = (x + y) / 2;
            GMean = Math.Sqrt(x * y);
        }
    }
}