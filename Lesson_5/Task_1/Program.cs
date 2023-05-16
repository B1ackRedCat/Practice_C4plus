namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                double y = Math.Cos(x * x) / (9 * x - 9) + Math.Pow(Math.Cos(x), 3);
                Console.WriteLine($"y = {y:f3}");
                Console.WriteLine("блок try выполнился успешно");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}