namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            Console.Write("Write numb of row: ");
            int colNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number to comparison: ");
            int compNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - Generate array. 2 - Manual input");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    GenerateArray(ref array);
                    break;
                case 2:
                    InputArray(ref array);
                    break;
            }
            Console.WriteLine("Array:");
            PrintArray(ref array);
            string message = Calculate(ref array, colNumb, compNumb) ? "Yes" : "No";
            Console.WriteLine(message);
        }

        static void InputArray(ref int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write($"Write the [{i + 1}, {j + 1}] element: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }

        static void PrintArray(ref int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }      
        }

        static bool Calculate(ref int[,] array, int colNumb, int compare)
        {
            int sum = 0;
            for (int j = 0; j <= array.GetUpperBound(1); j++)
                sum += array[colNumb, j];
            if (sum > compare)
                return true;
            else
                return false;
        }

        static void GenerateArray(ref int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i <= array.GetUpperBound(0); i++)
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                    array[i, j] = rand.Next(-10, 11);
        }
    }
}