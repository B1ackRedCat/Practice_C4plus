namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x = double.Parse(Console.ReadLine());
                double f;
                if (x >= 3)
                {
                    f = x;
                }
                else if (x > -1 && x < 3)
                {
                    f = -2 / x;
                }
                else if (x > -3 && x <= -1)
                {
                    f = 2 * x;
                }
                else
                    throw new ArgumentException("х не входит в диапазон условия");
                Console.WriteLine($"f = {f:f3}");
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