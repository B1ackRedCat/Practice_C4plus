namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double step = (Math.PI / 2 - Math.PI / 4) / 15;
            double result;
            double param = Math.PI / 4;
            for (int i = 1; i <= 15; i++)
            {
                result = 2 - Math.Sin(param);
                Console.WriteLine("f({0:f2}) = {1:f2}", param, result);
                param += step;
            }
        }
    }
}