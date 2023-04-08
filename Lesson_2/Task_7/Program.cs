namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 80;
            while (num >= 10)
            {
                Console.WriteLine("{0}", num);
                num -= 2;
            }
            Console.SetCursorPosition(0, 0);
            num = 80;
            do
            {
                Console.WriteLine("\t{0}", num);
                num -= 2;
            } while (num >= 10);
            Console.SetCursorPosition(0, 0);
            num = 80;
            for (; num >= 10; num -= 2)
                Console.WriteLine("\t\t{0}", num);
        }
    }
}