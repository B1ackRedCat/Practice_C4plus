namespace Task_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Console.Write("Write k: ");
            int k = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Sorted array:");
            Array.Sort(array);
            PrintArray(ref array);
            Console.WriteLine($"Count of elements not equal last element: {Calculate(ref array)}");
            Console.WriteLine($"Index of k element: {BinarySearch(ref array, k, 0, array.Length) + 1}");
        }

        static void InputArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Write the {i + 1} element: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void PrintArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }

        static int Calculate(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[49])
                    count++;
            }
            return count;
        }

        static void GenerateArray(ref int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-10, 11);
        }

        static int BinarySearch(ref int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }
            var middle = (first + last) / 2;
            var middleValue = array[middle];
            if (middleValue == searchedValue)
                return middle;
            else
            {
                if (middleValue > searchedValue)
                    return BinarySearch(ref array, searchedValue, first, middle - 1);
                else
                    return BinarySearch(ref array, searchedValue, middle + 1, last);
            }
        }
    }
}