namespace ClassLibrary1
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle()
        {

        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool Exists()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string Type()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return "Равносторонний";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                return "Равнобедренный";
            }
            else return "Разносторонний";
        }
    }
}