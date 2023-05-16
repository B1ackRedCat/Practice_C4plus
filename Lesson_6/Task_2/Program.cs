using System.Text;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Matrix matrix = new Matrix(n, n, a, b);
            Console.WriteLine(matrix);
            Console.Write("Sum of negative elements: ");
            var sum = matrix.GetNegativeSum();
            Console.WriteLine(sum);
            Console.Write("Count of even numbers: ");
            var count = matrix.GetEvenNumbers();
            Console.WriteLine(count);
        }
    }

    public class Matrix
    {
        private int[,] _array;
        private int _row;
        private int _col;

        public Matrix(int row, int col, int a, int b)
        {
            _row = row;
            _col = col;
            _array = new int[_row, _col];
            GenerateMatrix(a, b);
        }

        private void GenerateMatrix(int a, int b)
        {
            Random rand = new Random();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    _array[i, j] = rand.Next(a, b + 1);
                }
            }
        }

        public int GetEvenNumbers()
        {
            int count = 0;
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    if (_array[i, j] % 2 == 0 && _array[i, j] != 0)
                        count++;              
                }
            }
            return count;
        }

        public int GetNegativeSum()
        {
            int sum = 0;
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    if (_array[i, j] < 0)
                        sum += _array[i, j];
                }
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    sb.Append($"{_array[i, j]} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}