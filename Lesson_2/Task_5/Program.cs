namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
        }
    }
}