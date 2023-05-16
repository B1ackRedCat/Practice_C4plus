namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter the x: ");
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
                    throw new ArgumentException("x is out of range");
                Console.WriteLine($"f = {f:f3}");
                Console.WriteLine("try block succeeded");
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