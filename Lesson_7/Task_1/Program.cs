namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Spaces occur at the following positions:");

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}