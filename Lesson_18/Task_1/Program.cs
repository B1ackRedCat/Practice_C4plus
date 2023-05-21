using ClassLibrary1;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 4, 5);

            if (triangle.Exists())
            {
                double perimeter = triangle.Perimeter();
                double area = triangle.Area();
                string type = triangle.Type();
                Console.WriteLine($"Треугольник со сторонами ({triangle.SideA}, {triangle.SideB}, {triangle.SideC})");
                Console.WriteLine($"Тип треугольника: {type}\nПериметр триугольника: {perimeter}\nПлощадь треугольника: {area:f3}");
            }
            else { Console.WriteLine("Треугольник не существует"); }
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(3, 3);
            double perimeterR = rectangle.Perimeter();
            double areaR = rectangle.Area();

            Console.WriteLine($"Длина прямоугольника: {rectangle.Length}\nШирина прямоугольника: {rectangle.Width}\nПериметр: {perimeterR}\nПлощадь: {areaR}");
        }
    }
}