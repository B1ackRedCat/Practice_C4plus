namespace Task_2
{
    class Post
    {
        public string Title { get; set; }
        public int StandardHours { get; set; }

        public Post(string title, int standardHours)
        {
            Title = title;
            StandardHours = standardHours;
        }
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > worker.StandardHours;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Post worker = new Post("Employee", 40);
            Console.WriteLine("Enter working hours:");
            int hoursWorked = int.Parse(Console.ReadLine());

            Accountant accountant = new Accountant();
            bool bonus = accountant.AskForBonus(worker, hoursWorked);

            if (bonus)
            {
                Console.WriteLine("The employee is entitled to a bonus!");
            }
            else
            {
                Console.WriteLine("The employee is not entitled to a bonus.");
            }

            Console.ReadLine();
        }
    }
}