namespace Task_3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            Task<int> firstTask = Task.Run(() =>
            {
                int product = GetNumberPermutations(number);
                return product;
            });

            Task continuationTask = firstTask.ContinueWith(previousTask =>
            {
                int product = previousTask.Result;
                Console.Write($"Результат первой задачи: {product}\n");
            });
            await continuationTask;

            Console.WriteLine("Вторая задача завершена");
        }
        private static int GetNumberPermutations(int number)
        {

            int a = number / 100;
            int b = number / 10 % 10;
            int c = number % 10;

            return a * b * c;
        }
    }
}