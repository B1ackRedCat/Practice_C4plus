namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            int remainder = year % 12;
            switch (remainder)
            {
                case 1:
                    Console.WriteLine("Rooster");
                    break;
                case 2:
                    Console.WriteLine("Dog");
                    break;
                case 3:
                    Console.WriteLine("Pig");
                    break;
                case 4:
                    Console.WriteLine("Rat");
                    break;
                case 5:
                    Console.WriteLine("Ox");
                    break;
                case 6:
                    Console.WriteLine("Tiger");
                    break;
                case 7:
                    Console.WriteLine("Rabbit");
                    break;
                case 8:
                    Console.WriteLine("Dragon");
                    break;
                case 9:
                    Console.WriteLine("Snake");
                    break;
                case 10:
                    Console.WriteLine("Horse");
                    break;
                case 11:
                    Console.WriteLine("Goat");
                    break;
                case 0:
                    Console.WriteLine("Monkey");
                    break;
            }
        }
    }
}