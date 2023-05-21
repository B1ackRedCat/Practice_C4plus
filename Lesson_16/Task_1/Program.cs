namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<string>();
            list.Add("Grinko");
            list.Add("Mark");
            list.Add("37TP");
            Console.WriteLine($"Amount of elements: {list.Count}");
            Console.Write($"Enter the element index from 1 to {list.Count}: ");
            try
            {
                int ind = int.Parse(Console.ReadLine());
                Console.WriteLine($"Element at {ind} position: {list[ind - 1]}");
            }
            catch (Exception) { Console.WriteLine("There is no element with this index"); }
        }
    }
}