namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            MyInfo myInfo = new MyInfo(name);
            Console.Write($"{myInfo.Name} change to: ");
            myInfo.Name = Console.ReadLine();
        }
    }
}