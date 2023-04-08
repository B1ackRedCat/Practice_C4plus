namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mass in kilograms: ");
            int mass = int.Parse(Console.ReadLine());
            int newMass = mass / 100;
            Console.WriteLine($"Number of full centners: {newMass}");
        }
    }
}