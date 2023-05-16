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
            Post worker = new Post("Сотрудник", 160);
            int hoursWorked = 180;

            Accountant accountant = new Accountant();
            bool bonus = accountant.AskForBonus(worker, hoursWorked);

            if (bonus)
            {
                Console.WriteLine("Сотруднику положена премия!");
            }
            else
            {
                Console.WriteLine("Сотруднику не положена премия.");
            }

            Console.ReadLine();
        }
    }
}