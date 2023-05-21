namespace Task_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> values = new List<int> { 65, 2, 6, 87 };
            int sumThreshold = 1000000;

            Parallel.ForEach(values, (value, state) =>
            {
                int sum = 0;
                long product = 1;
                // Проверка условия прерывания
                //if (sum >= sumThreshold)
                //{
                //    state.Break();
                //    return;
                //}
                for (int i = 0; i < value + 1; i++)
                {
                    sum += i;
                    if (i != 0) { product *= i; }
                }

                Console.WriteLine($"Значение: {value}, Сумма: {sum}, Произведение: {product}");
            });

            Console.WriteLine("Вычисления завершены");
        }
    }
}