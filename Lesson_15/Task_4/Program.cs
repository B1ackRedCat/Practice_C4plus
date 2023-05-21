namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int numThreads = 3;
            Thread[] threads = new Thread[numThreads];
            int[] partialSums = new int[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() =>
                {
                    int sum = 0;
                    for (int j = threadIndex; j < array.Length; j += numThreads)
                    {
                        if (array[j] % 2 == 0)
                        {
                            sum += array[j];
                        }
                    }
                    partialSums[threadIndex] = sum;
                });
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            int totalSum = 0;
            for (int i = 0; i < numThreads; i++)
            {
                totalSum += partialSums[i];
            }

            Console.WriteLine($"Sum of even numbers: {totalSum}");
        }
    }
}