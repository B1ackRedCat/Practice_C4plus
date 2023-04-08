using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x >= 10)
                y = 4 + Math.Pow(x, 2) - Math.Exp(Math.Sqrt(x));
            else
                y = 3.4 - x + 0.1 * Math.Pow(x, 3);
            Console.WriteLine($"y = {y:f4}");
        }
    }
}