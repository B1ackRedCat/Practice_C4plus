namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Error: division by zero!");
                    return 0;
                }
            };

            while (true)
            {
                Console.WriteLine("Enter two numbers:");
                string input1 = Console.ReadLine();

                if (string.IsNullOrEmpty(input1))
                    break;

                string input2 = Console.ReadLine();

                if (string.IsNullOrEmpty(input2))
                    break;

                double num1, num2;

                if (double.TryParse(input1, out num1) && double.TryParse(input2, out num2))
                {
                    Console.WriteLine("Choose an operation: ");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");

                    int choice;

                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    {
                        double result = 0;

                        switch (choice)
                        {
                            case 1:
                                result = Add(num1, num2);
                                break;
                            case 2:
                                result = Sub(num1, num2);
                                break;
                            case 3:
                                result = Mul(num1, num2);
                                break;
                            case 4:
                                result = Div(num1, num2);
                                break;
                        }

                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect operation selection.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect number entry.");
                }

                Console.WriteLine();
            }
        }
    }
}