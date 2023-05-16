namespace Task_3
{
    internal class Program
    {
        private static void Main()
        {
            //data entry is in decimal format
            //data output is in hexadecimal format
            Console.Write("Enter min for counter: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max for counter: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Enter value for counter: ");
            int value = int.Parse(Console.ReadLine());
            HexadecimalCounter counter = new HexadecimalCounter(min, max, value);
            Console.WriteLine("Enter + to increase and - to decrease, otherwise to exit");
            do
            {
                var c = Console.ReadKey();
                if (c.KeyChar == '+')
                    counter.Increment();
                else if (c.KeyChar == '-')
                    counter.Decrement();
                else break;
                Console.WriteLine($" => {counter}");
            } while (true);
        }
    }
}