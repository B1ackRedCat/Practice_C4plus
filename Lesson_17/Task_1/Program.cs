namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int n = 0;
            while ((s = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();
            int[] mas = new int[n];
            int sum = 0;
            FileStream fileOne = new FileStream(@"f.txt", FileMode.Open);
            StreamReader readerOne = new StreamReader(fileOne);
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(readerOne.ReadLine());
                sum += mas[i];
            }

            int difference = mas[0] - mas[mas.Length - 1];
            Console.WriteLine($"Sum of File Components: {sum}\nDifference of the first and last component: {difference}");
        }
    }
}