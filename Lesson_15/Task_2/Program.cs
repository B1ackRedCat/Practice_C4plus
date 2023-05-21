namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadFirst = new Thread(CalculateSum);
            Thread threadSecond = new Thread(CalculateSum);

            DateTime start = DateTime.Now;

            threadFirst.Start();
            threadSecond.Start();

            threadFirst.Join();
            threadSecond.Join();

            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;

            Console.WriteLine($"Time elapsed: {elapsed.TotalMilliseconds} ms");
        }

        static void CalculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum = {sum} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
        }
    }
}