namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 0.5, 0.4, 5.6, 7.9 };
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"count = {arr.Length}");
        }
    }
}