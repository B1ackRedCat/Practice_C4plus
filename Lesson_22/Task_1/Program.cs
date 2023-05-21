namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[]
            {
                new Task(() => ThreadMethod("1")),
                new Task(() => ThreadMethod("2")),
                new Task(() => ThreadMethod("3")),
                new Task(() => ThreadMethod("4")),
                new Task(() => ThreadMethod("5"))
            };
            foreach (var task in tasks)
            {
                task.Start();
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Работа окончена...");
        }

        static void ThreadMethod(string query)
        {
            SingletonDatabase sd = SingletonDatabase.GetInstance();
            for (int i = 0; i < 5; i++)
            {
                sd.Query($"Запрос от {query} потока. Попытка: {i + 1}");
            }
        }
    }
}