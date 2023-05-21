namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            Task task1 = new Task(() => NumberGenerator(number));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => NumberGenerator(number));
            Task task3 = Task.Run(() => NumberGenerator(number));
            Console.ReadLine();
        }

        static void NumberGenerator(int number)
        {
            int a = number / 1000;
            int b = number / 100 % 10;
            int c = number / 10 % 10;
            int d = number % 10;

            Console.WriteLine($"Прочтение числа {number} справо налево:  {d}{c}{b}{a}");
        }
    }
}