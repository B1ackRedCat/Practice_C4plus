namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter length of column: ");
            int column = int.Parse(Console.ReadLine());
            Console.Write("Enter length of elements: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("1 - random; 2 - manual ");
            string input = Console.ReadLine();
            StringArray array1 = new StringArray(row, column, len);
            StringArray array2 = new StringArray(row, column, len); 
            switch (input)
            {
                case "1":
                    array1.GenerateArray();
                    array2.GenerateArray();
                    break;
                case "2":
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write($"{i + 1},{j + 1} element of 1 array: ");
                            array1[i, j] = Console.ReadLine();
                            Console.Write($"{i + 1},{j + 1} element of 2 array: ");
                            array2[i, j] = Console.ReadLine();
                        }
                    }
                    break;
                default:
                    array1.GenerateArray();
                    array2.GenerateArray();
                    break;
            }
            Console.WriteLine(array1);
            Console.WriteLine();
            Console.WriteLine(array2);
            Console.WriteLine($"1 array = 2 array: {array1 == array2}");
        }
    }
}