namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\New_folder");
        }
    }
}