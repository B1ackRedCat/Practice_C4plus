namespace Task_1
{
    internal class Program
    {
        static AutoResetEvent firstDone = new AutoResetEvent(false);
        static AutoResetEvent secondDone = new AutoResetEvent(false);
        static AutoResetEvent thirdDone = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread threadFirst = new Thread(new ThreadStart(FirstThread));
            Thread threadSecond = new Thread(new ThreadStart(SecondThread));
            Thread threadThird = new Thread(new ThreadStart(ThirdTread));

            threadFirst.Priority = ThreadPriority.AboveNormal;
            threadSecond.Priority = ThreadPriority.Normal;
            threadThird.Priority = ThreadPriority.BelowNormal;

            threadFirst.Start();
            threadSecond.Start();
            threadThird.Start();
        }
        static void FirstThread()
        {
            int count = 3;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The first stream outputs   {i}");
                Thread.Sleep(count);
                count *= 3;
            }
            Console.WriteLine("Completion of the first stream");
        }
        static void SecondThread()
        {
            int count = 6;
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine($"The second stream outputs   {i}");
                Thread.Sleep(count);
                count *= 3;
            }
            Console.WriteLine("Completion of the second stream");
        }
        static void ThirdTread()
        {
            int count = 9;
            for (int i = 20; i < 25; i++)
            {
                Console.WriteLine($"The third stream outputs   {i}\n");
                Thread.Sleep(count);
                count *= 3;
            }
            Console.WriteLine("Completion of the third stream");
        }
    }
}