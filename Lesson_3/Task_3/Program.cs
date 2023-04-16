namespace Task_3
{
    internal class Program
    {
        private static void Main()
        {

            Console.WriteLine("Введите минимум для счетчика");
            int min = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Введите максимум для счетчика");
            int max = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Введите значение для счетчика");
            int v = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Counter counter = new Counter(max, min, v);
            Console.WriteLine("Введите + для увеличение и - для уменьшения, иное для выхода");

            do
            {
                var c = Console.ReadKey();
                if (c.KeyChar == '+') counter.Increase();
                else if (c.KeyChar == '-') counter.Decrease();
                else break;
                Console.WriteLine($" => {counter.Value}");
            } while (true);

            Console.ReadKey();
        }
    }
}