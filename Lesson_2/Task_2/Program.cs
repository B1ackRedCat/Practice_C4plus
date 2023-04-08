namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            if (x < 0 && y > 0)
                Console.WriteLine("The point lies in the second quarter");
            else 
                Console.WriteLine("The point does not lie in the second quarter");
        }
    }
}