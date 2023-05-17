namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location[] localities = new Location[]
            {
                new City("Гродно", 10000, 100),
                new City("Гомель", 10000 ,100),
                new City ("Минск", 20000, 200),
                new Village("Свислочь", 200, 4, 4),
                new Village("Тихиничи", 100, 4, 3)
            };

            foreach (Location locality in localities)
            {
                Console.WriteLine($"Population density: {locality.GetPopulationDensity():.###}");
            }
            Console.Write("Lowest population density:");
            Console.Write(Location.GetMinPopulationDensity(localities));
        }
    }
}