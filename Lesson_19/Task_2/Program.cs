namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter range limits:");
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            string loadedText = File.ReadAllText(@"input.txt");

            Queue<int> numbers1 = new Queue<int>();
            Queue<int> numbers2 = new Queue<int>();
            Queue<int> numbers3 = new Queue<int>();

            foreach (string s in loadedText.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                int number = int.Parse(s);
                if (number >= a && number <= b) { numbers1.Enqueue(number); }
                else if (number < a) { numbers2.Enqueue(number); }
                else { numbers3.Enqueue(number); }
            }
            Console.Write(string.Join(" ", numbers1) + " " + string.Join(" ", numbers2) + " " + string.Join(" ", numbers3));
        }
    }
}