namespace Task_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double start = 0;
            double end = 10;
            int numSteps = 10;

            // Вычисление шага между значениями на отрезке
            double step = (end - start) / numSteps;

            // Вычисление значений функции с использованием Parallel.For
            Parallel.For(0, numSteps + 1, i =>
            {
                double x = start + i * step;
                double result = x * Math.Sin(x);

                Console.WriteLine($"Значение функции для x = {x}: {string.Format("{0:f3}", result)}");
            });

            Console.WriteLine("Вычисления завершены");
        }
    }
}