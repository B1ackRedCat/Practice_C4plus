namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());

            Thread threadFirst = new Thread(() => MethodOne(A, N));
            Thread threadSecond = new Thread(() => MethodOne(A, N));
            Thread threadThird = new Thread(() => MethodTwo(A, N));

            threadFirst.Start();
            threadSecond.Start();
            threadThird.Start();

            threadFirst.Join();
            threadSecond.Join();
            threadThird.Join();
        }

        static void MethodOne(int A, int N)
        {
            double sum = A;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(A, i);
            }
            Console.WriteLine($"First Method: Sum = {sum} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
        }

        static void MethodTwo(int A, int N)
        {
            double prod = A;
            for (int i = 1; i <= N; i++)
            {
                prod *= Math.Pow(A, i);
            }
            Console.WriteLine($"Second Method: Product = {prod} (Thread ID:{Thread.CurrentThread.ManagedThreadId})");
        }
    }
}